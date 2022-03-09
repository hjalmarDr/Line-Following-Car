using System.Drawing;

namespace SerialGUISample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.getIOtimer = new System.Windows.Forms.Timer(this.components);
            this.RightSenText = new System.Windows.Forms.TextBox();
            this.OutputBox1 = new System.Windows.Forms.NumericUpDown();
            this.Send1 = new System.Windows.Forms.Button();
            this.Send2 = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.LeftSenText = new System.Windows.Forms.TextBox();
            this.OutputBox2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SendKi = new System.Windows.Forms.Button();
            this.SendKp = new System.Windows.Forms.Button();
            this.KiOutput = new System.Windows.Forms.NumericUpDown();
            this.KpOutput = new System.Windows.Forms.NumericUpDown();
            this.SendInitSpeed = new System.Windows.Forms.Button();
            this.SendMaxSpeed = new System.Windows.Forms.Button();
            this.InitSpeed = new System.Windows.Forms.NumericUpDown();
            this.MaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.secLbl = new System.Windows.Forms.Label();
            this.mSecLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stopwatch = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.sendKd = new System.Windows.Forms.Button();
            this.KdOutput = new System.Windows.Forms.NumericUpDown();
            this.RSBox = new System.Windows.Forms.TextBox();
            this.LSBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KiOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpeed)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KdOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // serial
            // 
            this.serial.PortName = "COM10";
            // 
            // getIOtimer
            // 
            this.getIOtimer.Enabled = true;
            this.getIOtimer.Interval = 10;
            this.getIOtimer.Tick += new System.EventHandler(this.getIOtimer_Tick);
            // 
            // RightSenText
            // 
            this.RightSenText.Location = new System.Drawing.Point(448, 55);
            this.RightSenText.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.RightSenText.Name = "RightSenText";
            this.RightSenText.Size = new System.Drawing.Size(171, 22);
            this.RightSenText.TabIndex = 0;
            this.RightSenText.Text = "0";
            this.RightSenText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputBox1
            // 
            this.OutputBox1.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.OutputBox1.Location = new System.Drawing.Point(24, 57);
            this.OutputBox1.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.OutputBox1.Name = "OutputBox1";
            this.OutputBox1.Size = new System.Drawing.Size(185, 22);
            this.OutputBox1.TabIndex = 3;
            // 
            // Send1
            // 
            this.Send1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.Send1.Location = new System.Drawing.Point(237, 48);
            this.Send1.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.Send1.Name = "Send1";
            this.Send1.Size = new System.Drawing.Size(156, 38);
            this.Send1.TabIndex = 4;
            this.Send1.Text = "Right Motor";
            this.Send1.UseVisualStyleBackColor = true;
            this.Send1.Click += new System.EventHandler(this.Send1_Click);
            // 
            // Send2
            // 
            this.Send2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.Send2.Location = new System.Drawing.Point(237, 117);
            this.Send2.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.Send2.Name = "Send2";
            this.Send2.Size = new System.Drawing.Size(156, 38);
            this.Send2.TabIndex = 4;
            this.Send2.Text = "Left Motor";
            this.Send2.UseVisualStyleBackColor = true;
            this.Send2.Click += new System.EventHandler(this.Send2_Click);
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(24, 647);
            this.statusBox.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(717, 22);
            this.statusBox.TabIndex = 5;
            this.statusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LeftSenText
            // 
            this.LeftSenText.Location = new System.Drawing.Point(448, 126);
            this.LeftSenText.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.LeftSenText.Name = "LeftSenText";
            this.LeftSenText.Size = new System.Drawing.Size(171, 22);
            this.LeftSenText.TabIndex = 0;
            this.LeftSenText.Text = "0";
            this.LeftSenText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputBox2
            // 
            this.OutputBox2.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.OutputBox2.Location = new System.Drawing.Point(24, 123);
            this.OutputBox2.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.OutputBox2.Name = "OutputBox2";
            this.OutputBox2.Size = new System.Drawing.Size(185, 22);
            this.OutputBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "DUTY CYCLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(460, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "RIGHT SENSOR";
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.StartBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.Color.Black;
            this.StartBtn.Location = new System.Drawing.Point(72, 63);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(155, 65);
            this.StartBtn.TabIndex = 8;
            this.StartBtn.Text = "START";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.Red;
            this.StopBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBtn.ForeColor = System.Drawing.Color.Black;
            this.StopBtn.Location = new System.Drawing.Point(72, 135);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(155, 65);
            this.StopBtn.TabIndex = 9;
            this.StopBtn.Text = "STOP";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.ResetBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Controls.Add(this.StopBtn);
            this.panel1.Location = new System.Drawing.Point(448, 192);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 300);
            this.panel1.TabIndex = 10;
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Coral;
            this.ResetBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.Black;
            this.ResetBtn.Location = new System.Drawing.Point(72, 210);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(155, 65);
            this.ResetBtn.TabIndex = 12;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "CONTROL PANEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "PID CONSTANTS";
            // 
            // SendKi
            // 
            this.SendKi.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.SendKi.Location = new System.Drawing.Point(233, 447);
            this.SendKi.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.SendKi.Name = "SendKi";
            this.SendKi.Size = new System.Drawing.Size(160, 38);
            this.SendKi.TabIndex = 24;
            this.SendKi.Text = "Integral";
            this.SendKi.UseVisualStyleBackColor = true;
            this.SendKi.Click += new System.EventHandler(this.SendKi_Click);
            // 
            // SendKp
            // 
            this.SendKp.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.SendKp.Location = new System.Drawing.Point(233, 374);
            this.SendKp.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.SendKp.Name = "SendKp";
            this.SendKp.Size = new System.Drawing.Size(160, 38);
            this.SendKp.TabIndex = 25;
            this.SendKp.Text = "Proportional";
            this.SendKp.UseVisualStyleBackColor = true;
            this.SendKp.Click += new System.EventHandler(this.SendKp_Click);
            // 
            // KiOutput
            // 
            this.KiOutput.DecimalPlaces = 1;
            this.KiOutput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.KiOutput.Location = new System.Drawing.Point(24, 454);
            this.KiOutput.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.KiOutput.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            this.KiOutput.Name = "KiOutput";
            this.KiOutput.Size = new System.Drawing.Size(185, 22);
            this.KiOutput.TabIndex = 22;
            // 
            // KpOutput
            // 
            this.KpOutput.DecimalPlaces = 1;
            this.KpOutput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.KpOutput.Location = new System.Drawing.Point(24, 382);
            this.KpOutput.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.KpOutput.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            this.KpOutput.Name = "KpOutput";
            this.KpOutput.Size = new System.Drawing.Size(185, 22);
            this.KpOutput.TabIndex = 23;
            // 
            // SendInitSpeed
            // 
            this.SendInitSpeed.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.SendInitSpeed.Location = new System.Drawing.Point(233, 282);
            this.SendInitSpeed.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.SendInitSpeed.Name = "SendInitSpeed";
            this.SendInitSpeed.Size = new System.Drawing.Size(160, 38);
            this.SendInitSpeed.TabIndex = 29;
            this.SendInitSpeed.Text = "Initial Speed";
            this.SendInitSpeed.UseVisualStyleBackColor = true;
            this.SendInitSpeed.Click += new System.EventHandler(this.SendInitSpeed_Click);
            // 
            // SendMaxSpeed
            // 
            this.SendMaxSpeed.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.SendMaxSpeed.Location = new System.Drawing.Point(233, 208);
            this.SendMaxSpeed.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.SendMaxSpeed.Name = "SendMaxSpeed";
            this.SendMaxSpeed.Size = new System.Drawing.Size(160, 38);
            this.SendMaxSpeed.TabIndex = 30;
            this.SendMaxSpeed.Text = "Max Speed";
            this.SendMaxSpeed.UseVisualStyleBackColor = true;
            this.SendMaxSpeed.Click += new System.EventHandler(this.SendMaxSpeed_Click);
            // 
            // InitSpeed
            // 
            this.InitSpeed.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.InitSpeed.Location = new System.Drawing.Point(23, 289);
            this.InitSpeed.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.InitSpeed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.InitSpeed.Name = "InitSpeed";
            this.InitSpeed.Size = new System.Drawing.Size(187, 22);
            this.InitSpeed.TabIndex = 27;
            // 
            // MaxSpeed
            // 
            this.MaxSpeed.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.MaxSpeed.Location = new System.Drawing.Point(24, 217);
            this.MaxSpeed.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.MaxSpeed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.MaxSpeed.Name = "MaxSpeed";
            this.MaxSpeed.Size = new System.Drawing.Size(185, 22);
            this.MaxSpeed.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(64, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "SET SPEED";
            // 
            // secLbl
            // 
            this.secLbl.AutoSize = true;
            this.secLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLbl.Location = new System.Drawing.Point(60, 48);
            this.secLbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.secLbl.Name = "secLbl";
            this.secLbl.Size = new System.Drawing.Size(60, 46);
            this.secLbl.TabIndex = 31;
            this.secLbl.Text = "00";
            // 
            // mSecLbl
            // 
            this.mSecLbl.AutoSize = true;
            this.mSecLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSecLbl.Location = new System.Drawing.Point(180, 58);
            this.mSecLbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.mSecLbl.Name = "mSecLbl";
            this.mSecLbl.Size = new System.Drawing.Size(45, 34);
            this.mSecLbl.TabIndex = 32;
            this.mSecLbl.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(135, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 46);
            this.label7.TabIndex = 33;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(115, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "TIME";
            // 
            // stopwatch
            // 
            this.stopwatch.Enabled = true;
            this.stopwatch.Interval = 10;
            this.stopwatch.Tick += new System.EventHandler(this.stopwatch_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.secLbl);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.mSecLbl);
            this.panel2.Location = new System.Drawing.Point(448, 517);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 96);
            this.panel2.TabIndex = 34;
            // 
            // sendKd
            // 
            this.sendKd.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.sendKd.Location = new System.Drawing.Point(233, 512);
            this.sendKd.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.sendKd.Name = "sendKd";
            this.sendKd.Size = new System.Drawing.Size(160, 38);
            this.sendKd.TabIndex = 46;
            this.sendKd.Text = "Derivative";
            this.sendKd.UseVisualStyleBackColor = true;
            this.sendKd.Click += new System.EventHandler(this.sendKd_Click);
            // 
            // KdOutput
            // 
            this.KdOutput.DecimalPlaces = 1;
            this.KdOutput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.KdOutput.Location = new System.Drawing.Point(24, 519);
            this.KdOutput.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.KdOutput.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            this.KdOutput.Name = "KdOutput";
            this.KdOutput.Size = new System.Drawing.Size(185, 22);
            this.KdOutput.TabIndex = 45;
            // 
            // RSBox
            // 
            this.RSBox.BackColor = System.Drawing.SystemColors.Window;
            this.RSBox.Location = new System.Drawing.Point(644, 42);
            this.RSBox.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.RSBox.Multiline = true;
            this.RSBox.Name = "RSBox";
            this.RSBox.Size = new System.Drawing.Size(97, 50);
            this.RSBox.TabIndex = 51;
            this.RSBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LSBox
            // 
            this.LSBox.Location = new System.Drawing.Point(644, 110);
            this.LSBox.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.LSBox.Multiline = true;
            this.LSBox.Name = "LSBox";
            this.LSBox.Size = new System.Drawing.Size(97, 51);
            this.LSBox.TabIndex = 52;
            this.LSBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(468, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "LEFT SENSOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(767, 687);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LSBox);
            this.Controls.Add(this.RSBox);
            this.Controls.Add(this.sendKd);
            this.Controls.Add(this.KdOutput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SendInitSpeed);
            this.Controls.Add(this.SendMaxSpeed);
            this.Controls.Add(this.InitSpeed);
            this.Controls.Add(this.MaxSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SendKi);
            this.Controls.Add(this.SendKp);
            this.Controls.Add(this.KiOutput);
            this.Controls.Add(this.KpOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.Send2);
            this.Controls.Add(this.Send1);
            this.Controls.Add(this.OutputBox2);
            this.Controls.Add(this.OutputBox1);
            this.Controls.Add(this.LeftSenText);
            this.Controls.Add(this.RightSenText);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.Name = "Form1";
            this.Text = "LINE FOLLOWER GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KiOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KpOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpeed)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KdOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer getIOtimer;
        private System.Windows.Forms.TextBox RightSenText;
        private System.Windows.Forms.NumericUpDown OutputBox1;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Button Send1;
        private System.Windows.Forms.Button Send2;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.TextBox LeftSenText;
        private System.Windows.Forms.NumericUpDown OutputBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SendKi;
        private System.Windows.Forms.Button SendKp;
        private System.Windows.Forms.NumericUpDown KiOutput;
        private System.Windows.Forms.NumericUpDown KpOutput;
        private System.Windows.Forms.Button SendInitSpeed;
        private System.Windows.Forms.Button SendMaxSpeed;
        private System.Windows.Forms.NumericUpDown InitSpeed;
        private System.Windows.Forms.NumericUpDown MaxSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label secLbl;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label mSecLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer stopwatch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sendKd;
        private System.Windows.Forms.NumericUpDown KdOutput;
        private System.Windows.Forms.TextBox RSBox;
        private System.Windows.Forms.TextBox LSBox;
        private System.Windows.Forms.Label label6;
    }
}

