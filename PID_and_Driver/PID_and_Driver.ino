//Declare variables for each byte of the message.
byte startByte = 0;
byte commandByte = 0;
byte dataByte = 0;
byte checkByte = 0;

//Declare variables for storing the port values.
byte output1 = 255;
byte output2 = 255;
byte input1 = 0;
byte input2 = 0;

//Declare variable for calculating the check sum which is used to confirm that the correct bytes were identified as the four message bytes.
byte checkSum = 0;

//Declare a constant for the start byte ensuring that the value is static.
const byte START = 255;

#define DT 0.001

//Mode flag used in conjuction with start and stop buttons
int Mode = 0;

//DAC Pins
const byte DACPIN1[8] = {2, 3, 4, 5, 6, 7, 8, 9};
const byte DACPIN2[8] = {A3, A2, A1, A0, 12, 11, 10, 13};

//DRIVE CONTROL VARIABLES (PID)
//Analog Inputs
int Rsensor = 0;
int Lsensor = 0;

//Relevant Speeds
int max_speed = 255;
int initial_speed = 255;
const int stop_speed = 128;
int left_speed = 0;
int right_speed = 0;

//PID Control Variables
//Kp is the constant used to vary the magnitude of the change required to achieve the set point
float Kp = 1.1;
//Ki is the the constant used to vary the rate at which the change should be brought in the physical quantity to achieve the set point
float Ki = 0.2;
//Kd is the constant used to vary the stability of the system
float Kd = 1.2;

//PID variables for right motor
float Rerror_1024 = 0, R_P = 0, R_I = 0, R_D = 0, R_PID_value = 0;
float Rprevious_error = 0;
float Rtarget = 932;
int Rerror;

//PID variables for left motor
float Lerror_1024 = 0, L_P = 0, L_I = 0, L_D = 0, L_PID_value = 0;
float Lprevious_error = 0;
float Ltarget = 885;
int Lerror;


//Output binary value (from byte value) to DAC Pins for Right Motor
void outputToDAC1( byte data ) //loop through lookup table of Arduino pins connected to DAC and write correct bit to each
{
  for ( int i = 0; i <= 7; i++ )
  {
    digitalWrite( DACPIN1[i] , ((data >> i) & 1 ? HIGH : LOW));
  }
}

//Output binary value (from byte value) to DAC Pins for Left Motor
void outputToDAC2( byte data ) //loop through lookup table of Arduino pins connected to DAC and write correct bit to each
{
  for ( int i = 0; i <= 7; i++ )
  {
    digitalWrite( DACPIN2[i] , ((data >> i) & 1 ? HIGH : LOW));
  }
}

//loop through lookup table of Arduino pins connected to DAC and set to output mode
void initDACs()
{
  for ( int i = 0; i <= 7; i++ )
  {
    pinMode( DACPIN1[i] , OUTPUT);
    pinMode( DACPIN2[i] , OUTPUT);
  }
}

//Perform serial communication between Arduino and Visual Studio
void serialComm() {
  read_sensors();
  if (Serial.available() >= 4) // Check that a full package of four bytes has arrived in the buffer.
  {
    startByte = Serial.read(); // Get the first available byte from the buffer, assuming that it is the start byte.

    if (startByte == START) // Confirm that the first byte was the start byte, otherwise begin again checking the next byte.
    {
      //Read the remaining three bytes of the package into the respective variables.
      commandByte = Serial.read();
      dataByte = Serial.read();
      checkByte = Serial.read();

      checkSum = startByte + commandByte + dataByte; // Calculate the check sum, this is also calculated in visual studio and is sent as he final byte of the package.

      if (checkByte == checkSum) //Confirm that the calculated and sent check sum match, if so it is safe to process the data.
      {
        //Check the command byte to determine which port is being called and respond accordingly.
        switch (commandByte)
        {
          case 0: //Send a digital value to GUI for right sensor
            {
              if (Rsensor > 700)
              {
                input1 = 1;
              }
              else
              {
                input1 = 0;
              }
              Rsensor = analogRead(A4);
              Serial.write(START); //Send the start byte indicating the start of a package.
              Serial.write(commandByte); //Echo the command byte to inform Visual Studio which port value is being sent.
              Serial.write(input1); //Send the value read.
              int checkSum1 = START + commandByte + input1; //Calculate the check sum.
              Serial.write(checkSum1); //Send the check sum.
            }
            break;
          case 1: //Send a digital value to GUI for left sensor
            {
              if (Lsensor > 700)
              {
                input2 = 1;
              }
              else
              {
                input2 = 0;
              }
              Lsensor = analogRead(A5);
              Serial.write(START); //Send the start byte indicating the start of a package.
              Serial.write(commandByte); //Echo the command byte to inform Visual Studio which port value is being sent.
              Serial.write(input2); //Send the value read.
              int checkSum2 = START + commandByte + input2; //Calculate the check sum.
              Serial.write(checkSum2); //Send the check sum.
            }
            break;
          case 2: //For Output 1 the value of the data byte is written to pins in DACPIN1.
            {
              output1 = dataByte;    //The value of the data byte is stored in variable output 1, this step is redundant as the value could be written directly to the port.
              outputToDAC1(output1);       //However keeping the data in a variable could prove useful if further processing was done on the arduino side.
            }
            break;
          case 3: //For Output 1 the value of the data byte is written to pins in DACPIN2.
            {
              output2 = dataByte;
              outputToDAC2(output2);
            }
            break;
          case 4: //Case used to change mode (vehicle running or not)
            {
              Mode = (int)dataByte;
            }
            break;
          case 5: //Used to change Kp value via GUI
            {
              Kp = dataByte / 100;
            }
            break;
          case 6: //Used to change Ki value via GUI
            {
              Ki = dataByte / 100;
            }
            break;
          case 7: //Used to change Kd value via GUI
            {
              Kd = dataByte / 100;
            }
            break;
          case 8: //Used to change max_speed value via GUI
            {
              max_speed = dataByte;
            }
            break;
          case 9: //Used to change initial_speed value via GUI
            {
              initial_speed = dataByte;
            }
            break;
        }
      }
    }
  }
}

void read_sensors()
{
  //Analog read from both sensors
  Rsensor = analogRead(A4);
  Lsensor = analogRead(A5);
}

//Calculates error using distance from target with PID feedback control
void calculatePID()
{
  //read current sensor readings
  read_sensors();

  R_P = Rerror;                    //Term is proportional to the error
  R_I = R_I + Rerror;              //This term is the sum of all the previous error values
  R_D = Rerror - Rprevious_error;  //This term is the difference between the instantaneous error from the set point, and the error from the previous instant

  R_PID_value = ((Kp * R_P) + (Ki * R_I) + (Kd * R_D));

  L_P = Lerror;                    //Term is proportional to the error
  L_I = L_I + Lerror;              //This term is the sum of all the previous error values
  L_D = Lerror - Lprevious_error;  //This term is the difference between the instantaneous error from the set point, and the error from the previous instant

  L_PID_value = ((Kp * L_P) + (Ki * L_I) + (Kd * L_D));

  Rprevious_error = Rerror;
  Lprevious_error = Lerror;
}

//Control motors depeding on calculated PID values
void motorControl()
{
  //Error threshold of 20 used to determine if change needed
  if (Rerror > 20)
  {
    right_speed = initial_speed - R_PID_value;
  }
  else if (Rerror < -20)
  {
    right_speed = initial_speed + R_PID_value;
  }
  else
  {
    right_speed = initial_speed;
  }

  //Error threshold of 20 used to determine if change needed
  if (Lerror > 20)
  {
    left_speed = initial_speed - L_PID_value;
  }
  else if (Lerror < -20)
  {
    left_speed = initial_speed + L_PID_value;
  }
  else
  {
    left_speed = initial_speed;
  }

  //Constrain speeds to 0-255 range
  left_speed = constrain(left_speed, 0, 255);
  right_speed = constrain(right_speed, 0, 255);

  //Output values to both DACs
  outputToDAC2(right_speed);
  outputToDAC1(left_speed); 
}

//Setup initialises pins as inputs or outputs and begins the serial.
void setup()
{
  Serial.begin(9600);
  initDACs();
}

void loop()
{
  //Mode = 1;
  //Mode flag used with button presses on GUI
  if (Mode == 1)
  {
    //run serial comms in the loop to update whether the sensors are reading white or black
    serialComm();
    //Time used to determine interval of integral
    unsigned long my_time = millis();
    //Reset I value after time interval
    R_I = 0;
    L_I = 0;
    //Determine motor operations over interval of 1 second
    do
    {
      //Read current sensor values
      read_sensors();
      //Determine error from target using analog values
      Rerror_1024 = Rtarget - Rsensor;
      Lerror_1024 = Ltarget - Lsensor;
      //Map these values between 0-255
      Rerror = map(Rerror_1024, 0, 1024, 0, 255);
      Lerror = map(Lerror_1024, 0, 1024, 0, 255);
      //No error (full speed ahead)
      if (Lerror < 30 && Rerror < 30)
      {
        outputToDAC1(max_speed);
        outputToDAC2(max_speed);

      }
      //If both sensors on white, stop vehicle
      else if (Rsensor < 700 && Lsensor < 700)
      {
        outputToDAC1(stop_speed);
        outputToDAC2(stop_speed);
      }
      //Calculate motor control based on position and error
      else
      {
        calculatePID();
        motorControl();
      }
      //delay between each motor speed change within the integral
      delay(150);
    } while (millis() - my_time < DT*1000000);
  }
  //Stop vehicle if stop button is active
  else
  {
    outputToDAC1(stop_speed);
    outputToDAC2(stop_speed);
  }
  //Perform serial communication continuously
  serialComm();
}
