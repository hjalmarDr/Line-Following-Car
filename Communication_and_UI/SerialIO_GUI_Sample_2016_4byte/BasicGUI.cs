// Curtin University
// Mechatronics Engineering
// GUI and Serial Comm for Line Following Vehicle
// Damian Hancock and Hjalmar Dressel

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization.Configuration;

namespace SerialGUISample
{

    public partial class Form1 : Form
    {
        // Declare variables to store inputs and outputs.
        bool runSerial = true;
        //bool byteRead = false;
        int Input1 = 0;
        int Input2 = 0;

        byte[] Outputs = new byte[4];
        byte[] Inputs = new byte[4];

        const byte START = 255;
        const byte ZERO = 0;

        int timeMs, timeSec;
        bool isActive;

        public Form1()
        {
            // Initialize required for form controls.
            InitializeComponent();

            // Establish connection with serial
            if (runSerial == true)
            {
                if (!serial.IsOpen)                                  // Check if the serial has been connected.
                {
                    try
                    {
                        serial.Open();                               //Try to connect to the serial.
                        statusBox.Text = "SERIAL CONNECTION SUCCESSFUL"; //If serial connect display a message
                    }
                    catch
                    {
                        statusBox.Enabled = false;
                        statusBox.Text = "SERIAL CONNECTION FAILED";     //If the serial does not connect return an error.
                    }
                }
            }
        }

        // Send a four byte message to the Arduino via serial.
        private void sendIO(byte PORT, byte DATA)
        {
            Outputs[0] = START;    //Set the first byte to the start value that indicates the beginning of the message.
            Outputs[1] = PORT;     //Set the second byte to represent the port where, Input 1 = 0, Input 2 = 1, Output 1 = 2 & Output 2 = 3. This could be enumerated to make writing code simpler... (see Arduino driver)
            Outputs[2] = DATA;  //Set the third byte to the value to be assigned to the port. This is only necessary for outputs, however it is best to assign a consistent value such as 0 for input ports.
            Outputs[3] = (byte)(START + PORT + DATA); //Calculate the checksum byte, the same calculation is performed on the Arduino side to confirm the message was received correctly.

            if (serial.IsOpen)
            {
                serial.Write(Outputs, 0, 4);         //Send all four bytes to the IO card.                      
            }
        }

        private void Send1_Click(object sender, EventArgs e) //Press the button to send the value to Output 1, Arduino Port A.
        {
            byte Motor1 = (byte)(Math.Round(((double)OutputBox1.Value) - 0.16) / (0.39));
            if (OutputBox1.Value == 100)
            {
                Motor1 = 255;
            }

            sendIO(2, Motor1); // The value 2 indicates Output1, value for output set in OutputBox1.
        }

        private void Send2_Click(object sender, EventArgs e) //Press the button to send the value to Output 2, Arduino Port C.
        {
            byte Motor2 = (byte)(Math.Round(((double)OutputBox2.Value) - 0.16) / (0.39));
            if (OutputBox2.Value == 100)
            {
                Motor2 = 255;
            }

            sendIO(3, Motor2); // The value 3 indicates Output2, value for output set in OutputBox1.
        }

        private void getIOtimer_Tick(object sender, EventArgs e) //It is best to continuously check for incoming data as handling the buffer or waiting for event is not practical in C#.
        {
            if (serial.IsOpen) //Check that a serial connection exists.
            {
                if (serial.BytesToRead >= 4) //Check that the buffer contains a full four byte package.
                {
                    //statusBox.Text = "Incoming"; // A status box can be used for debugging code.
                    Inputs[0] = (byte)serial.ReadByte(); //Read the first byte of the package.

                    if (Inputs[0] == START) //Check that the first byte is in fact the start byte.
                    {
                        //statusBox.Text = "Start Accepted";

                        //Read the rest of the package.
                        Inputs[1] = (byte)serial.ReadByte();
                        Inputs[2] = (byte)serial.ReadByte();
                        Inputs[3] = (byte)serial.ReadByte();
                        //constantly receive inputs 0 and 1
                        sendIO(0, ZERO);
                        sendIO(1, ZERO);
                        //Calculate the checksum.
                        byte checkSum = (byte)(Inputs[0] + Inputs[1] + Inputs[2]);

                        //Check that the calculated check sum matches the checksum sent with the message.
                        if (Inputs[3] == checkSum)
                        {
                            //statusBox.Text = "CheckSum Accepted";

                            //Check which port the incoming data is associated with.
                            switch (Inputs[1])
                            {
                                case 0: //Save the data to a variable and place in the textbox.
                                    Input1 = Inputs[2];
                                    if (Input1 == 1)
                                    {
                                        RightSenText.Text = "BLACK";
                                        RSBox.BackColor = Color.Black;
                                    }
                                    else
                                    {
                                        RightSenText.Text = "WHITE";
                                        RSBox.BackColor = Color.White;
                                    }
                                    break;
                                case 1: //Save the data to a variable and place in the textbox. 
                                    Input2 = Inputs[2];
                                    if(Input2 == 1)
                                    {
                                        LeftSenText.Text = "BLACK";
                                        LSBox.BackColor = Color.Black;
                                    }
                                    else
                                    {
                                        LeftSenText.Text = "WHITE";
                                        LSBox.BackColor = Color.White;
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)     //use start button to start motor run and initialise timer
        {
            sendIO(0, ZERO);
            //sendIO(1, ZERO);
            isActive = true;
            int Mode = 1;
            sendIO(4, (byte)Mode);
        }

        private void StopBtn_Click(object sender, EventArgs e)      //stops the motors and timer
        {
            isActive = false;
            int Mode = 0;
            sendIO(4, (byte)Mode);
        }

        private void Form1_Load(object sender, EventArgs e)         //reset timer when program starts
        {
            resetTime();
            isActive = false;
        }

        private void ResetBtn_Click(object sender, EventArgs e)     //reset timer with button press
        {
            isActive = false;
            resetTime();
        }

        private void stopwatch_Tick(object sender, EventArgs e)     //stopwatch algorithm
        {
            if (isActive)
            {
                timeMs++;
                if(timeMs > 62)     //62 used as there is lag within visual studio, 62 makes it accurate with real time
                {
                    timeSec++;
                    timeMs = 0;
                }
            }
            drawTime();
        }

        private void drawTime()     //display time on the GUI in string format
        {
            mSecLbl.Text = String.Format("{0:00}", timeMs);
            secLbl.Text = String.Format("{0:00}", timeSec);
        }

        private void SendKp_Click(object sender, EventArgs e)       //send Kp value to arduino
        {
            byte Kp = (byte)(KpOutput.Value*100);
            sendIO(5, Kp);
        }

        private void SendKi_Click(object sender, EventArgs e)       //send Ki value to arduino
        {
            byte Ki = (byte)(KiOutput.Value * 100);
            sendIO(6, Ki);
        }

        private void sendKd_Click(object sender, EventArgs e)       //send Kd value to arduino
        {
            byte Kd = (byte)(KdOutput.Value*100);
            sendIO(7, Kd);
        }

        private void SendMaxSpeed_Click(object sender, EventArgs e) //send max_speed value to arduino
        {
            byte mSpeed = (byte)MaxSpeed.Value;
            sendIO(8, mSpeed);
        }

        private void SendInitSpeed_Click(object sender, EventArgs e)//send initial_speed value to arduino
        {
            byte iSpeed = (byte)InitSpeed.Value;
            sendIO(9, iSpeed);
        }

        private void resetTime()        //resets the time
        {
            timeMs = 0;
            timeSec = 0;
        }
    }

}