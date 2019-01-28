namespace OrientApp
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.tb_NaviPoistionNorth = new System.Windows.Forms.TextBox();
            this.tb_NaviPoistionEast = new System.Windows.Forms.TextBox();
            this.label_NaviPoistionNorth = new System.Windows.Forms.Label();
            this.label_NaviPoistionEast = new System.Windows.Forms.Label();
            this.label_NaviOrientation = new System.Windows.Forms.Label();
            this.tb_NaviOrientation = new System.Windows.Forms.TextBox();
            this.rtb_SerialData = new System.Windows.Forms.RichTextBox();
            this.gb_ParametersSpeedRun = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label_V01 = new System.Windows.Forms.Label();
            this.label_mm01 = new System.Windows.Forms.Label();
            this.label_A01 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gb_BoardLineInformations = new System.Windows.Forms.GroupBox();
            this.label_mm02 = new System.Windows.Forms.Label();
            this.label_BoardLineSecondLine = new System.Windows.Forms.Label();
            this.label_BoardLineMainLine = new System.Windows.Forms.Label();
            this.label_BoardLineNumberOfLines = new System.Windows.Forms.Label();
            this.tb_BoardLineSecondLinePos = new System.Windows.Forms.TextBox();
            this.tb_BoardLineMainLinePos = new System.Windows.Forms.TextBox();
            this.tb_BoardLineLineNumber = new System.Windows.Forms.TextBox();
            this.trackBar_BoardLineMainLinePos = new System.Windows.Forms.TrackBar();
            this.trackBar_BoardLineSecondLinePos = new System.Windows.Forms.TrackBar();
            this.gb_BoardMotorInformations = new System.Windows.Forms.GroupBox();
            this.label_V02 = new System.Windows.Forms.Label();
            this.label_mA02 = new System.Windows.Forms.Label();
            this.label_mA01 = new System.Windows.Forms.Label();
            this.label_BoardMotorServoCurrent = new System.Windows.Forms.Label();
            this.label_BoardMotorSystemCurrent = new System.Windows.Forms.Label();
            this.label_BoardMotorMotorCurrent = new System.Windows.Forms.Label();
            this.label_BoardMotorSecondaryBatteryVoltage = new System.Windows.Forms.Label();
            this.tb_BoardMotorServoCurrent = new System.Windows.Forms.TextBox();
            this.tb_BoardMotorSystemCurrent = new System.Windows.Forms.TextBox();
            this.tb_BoardMotorMotorCurrent = new System.Windows.Forms.TextBox();
            this.tb_BoardMotorSecondaryBatteryVoltage = new System.Windows.Forms.TextBox();
            this.label_BoardMotorMainBatteryVoltage = new System.Windows.Forms.Label();
            this.tb_BoardMotorMainBatteryVoltage = new System.Windows.Forms.TextBox();
            this.trackBar_BoardMotorMainBatteryVoltage = new System.Windows.Forms.TrackBar();
            this.gb_SteeringWheel = new System.Windows.Forms.GroupBox();
            this.label_deg02 = new System.Windows.Forms.Label();
            this.tb_SteeringWheelAngle = new System.Windows.Forms.TextBox();
            this.label_SteeringWheelAngle = new System.Windows.Forms.Label();
            this.bg_Encoder = new System.Windows.Forms.GroupBox();
            this.label_EncoderVelocity = new System.Windows.Forms.Label();
            this.tb_EncoderVelocity = new System.Windows.Forms.TextBox();
            this.label_m_s01 = new System.Windows.Forms.Label();
            this.gb_DistanceSensors = new System.Windows.Forms.GroupBox();
            this.btn_DistanceCollisionWarningRear = new System.Windows.Forms.Button();
            this.btn_DistanceCollisionWarningFront = new System.Windows.Forms.Button();
            this.btn_DistanceCollisionWarningFrontRight = new System.Windows.Forms.Button();
            this.btn_DistanceCollisionWarningRight = new System.Windows.Forms.Button();
            this.label_DistanceSensorRear = new System.Windows.Forms.Label();
            this.label_DistanceSensorToFRight = new System.Windows.Forms.Label();
            this.label_DistanceSensorToFFrontRight = new System.Windows.Forms.Label();
            this.label_DistanceSensorToFFront = new System.Windows.Forms.Label();
            this.tb_DistanceSensorRear = new System.Windows.Forms.TextBox();
            this.tb_DistanceSensorRight = new System.Windows.Forms.TextBox();
            this.tb_DistanceSensorFrontRight = new System.Windows.Forms.TextBox();
            this.tb_DistanceSensorFront = new System.Windows.Forms.TextBox();
            this.gb_InertialSensor = new System.Windows.Forms.GroupBox();
            this.label_InertialSensorAngularAccelerationName = new System.Windows.Forms.Label();
            this.label_InertialSensorAccelerationName = new System.Windows.Forms.Label();
            this.tb_InertialAngularVelocityPhi = new System.Windows.Forms.TextBox();
            this.tb_InertialAngularVelocityTheta = new System.Windows.Forms.TextBox();
            this.label_rad_s_01 = new System.Windows.Forms.Label();
            this.label_IntertialAngularVelocityTheta = new System.Windows.Forms.Label();
            this.label_m2_s01 = new System.Windows.Forms.Label();
            this.label_IntertialAngularVelocityPsi = new System.Windows.Forms.Label();
            this.tb_InertialAngularVelocityPsi = new System.Windows.Forms.TextBox();
            this.label_IntertialAngularVelocityPhi = new System.Windows.Forms.Label();
            this.tb_InertialAccelerationX = new System.Windows.Forms.TextBox();
            this.tb_InertialAccelerationY = new System.Windows.Forms.TextBox();
            this.label_IntertialAccelerationY = new System.Windows.Forms.Label();
            this.label_IntertialAccelerationZ = new System.Windows.Forms.Label();
            this.tb_InertialAccelerationZ = new System.Windows.Forms.TextBox();
            this.label_IntertialAccelerationX = new System.Windows.Forms.Label();
            this.gb_NavigationData = new System.Windows.Forms.GroupBox();
            this.label_deg01 = new System.Windows.Forms.Label();
            this.label_m02 = new System.Windows.Forms.Label();
            this.label_m01 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gb_SerialContainer = new System.Windows.Forms.GroupBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.tb_SerialStatusInfo = new System.Windows.Forms.TextBox();
            this.tb_SerialBaude = new System.Windows.Forms.TextBox();
            this.label_SerialBaude = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label_SerialComPort = new System.Windows.Forms.Label();
            this.btn_Open = new System.Windows.Forms.Button();
            this.cb_SerialComPort = new System.Windows.Forms.ComboBox();
            this.gb_MazeRunParameters = new System.Windows.Forms.GroupBox();
            this.btn_MazeParametersGetParams = new System.Windows.Forms.Button();
            this.label_MazeParametersGetValue = new System.Windows.Forms.Label();
            this.tb_MazeParametersGetState = new System.Windows.Forms.TextBox();
            this.tb_MazeParametersGetSpeed = new System.Windows.Forms.TextBox();
            this.tb_MazeParametersGetKD = new System.Windows.Forms.TextBox();
            this.tb_MazeParametersGetKP = new System.Windows.Forms.TextBox();
            this.tb_MazeParametersSetState = new System.Windows.Forms.TextBox();
            this.btn_MazeParametersSetStateTo = new System.Windows.Forms.Button();
            this.label_MazeParametersResetStateTo = new System.Windows.Forms.Label();
            this.tb_MazeParametersSetStateTo = new System.Windows.Forms.TextBox();
            this.label_MazeParametersSetValue = new System.Windows.Forms.Label();
            this.label_MazeParametersActualValues = new System.Windows.Forms.Label();
            this.tb_MazeParametersSetSpeed = new System.Windows.Forms.TextBox();
            this.tb_MazeParametersSetKD = new System.Windows.Forms.TextBox();
            this.tb_MazeParametersSetKP = new System.Windows.Forms.TextBox();
            this.label_MazeParametersActualState = new System.Windows.Forms.Label();
            this.tb_MazeParametersActualState = new System.Windows.Forms.TextBox();
            this.btn_MazeParametersSendParams = new System.Windows.Forms.Button();
            this.label_MazeParametersSpeed = new System.Windows.Forms.Label();
            this.tb_MazeParametersActualSpeed = new System.Windows.Forms.TextBox();
            this.label_MazeParametersKD = new System.Windows.Forms.Label();
            this.tb_MazeParametersActualKD = new System.Windows.Forms.TextBox();
            this.label_MazeParametersKP = new System.Windows.Forms.Label();
            this.tb_MazeParametersActualKP = new System.Windows.Forms.TextBox();
            this.pict_TeamLogo = new System.Windows.Forms.PictureBox();
            this.pic_Car2 = new System.Windows.Forms.PictureBox();
            this.pic_SteeringWheel = new System.Windows.Forms.PictureBox();
            this.pic_Car1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.gb_NaviMap = new System.Windows.Forms.GroupBox();
            this.gb_Scope = new System.Windows.Forms.GroupBox();
            this.gb_ParametersSpeedRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gb_BoardLineInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BoardLineMainLinePos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BoardLineSecondLinePos)).BeginInit();
            this.gb_BoardMotorInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BoardMotorMainBatteryVoltage)).BeginInit();
            this.gb_SteeringWheel.SuspendLayout();
            this.bg_Encoder.SuspendLayout();
            this.gb_DistanceSensors.SuspendLayout();
            this.gb_InertialSensor.SuspendLayout();
            this.gb_NavigationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gb_SerialContainer.SuspendLayout();
            this.gb_MazeRunParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_TeamLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SteeringWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.PortName = "COM5";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tb_NaviPoistionNorth
            // 
            this.tb_NaviPoistionNorth.Location = new System.Drawing.Point(31, 26);
            this.tb_NaviPoistionNorth.Name = "tb_NaviPoistionNorth";
            this.tb_NaviPoistionNorth.ReadOnly = true;
            this.tb_NaviPoistionNorth.Size = new System.Drawing.Size(50, 20);
            this.tb_NaviPoistionNorth.TabIndex = 0;
            this.tb_NaviPoistionNorth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_NaviPoistionEast
            // 
            this.tb_NaviPoistionEast.Location = new System.Drawing.Point(31, 52);
            this.tb_NaviPoistionEast.Name = "tb_NaviPoistionEast";
            this.tb_NaviPoistionEast.ReadOnly = true;
            this.tb_NaviPoistionEast.Size = new System.Drawing.Size(50, 20);
            this.tb_NaviPoistionEast.TabIndex = 1;
            this.tb_NaviPoistionEast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_NaviPoistionNorth
            // 
            this.label_NaviPoistionNorth.AutoSize = true;
            this.label_NaviPoistionNorth.Location = new System.Drawing.Point(7, 29);
            this.label_NaviPoistionNorth.Name = "label_NaviPoistionNorth";
            this.label_NaviPoistionNorth.Size = new System.Drawing.Size(18, 13);
            this.label_NaviPoistionNorth.TabIndex = 2;
            this.label_NaviPoistionNorth.Text = "N:";
            // 
            // label_NaviPoistionEast
            // 
            this.label_NaviPoistionEast.AutoSize = true;
            this.label_NaviPoistionEast.Location = new System.Drawing.Point(6, 55);
            this.label_NaviPoistionEast.Name = "label_NaviPoistionEast";
            this.label_NaviPoistionEast.Size = new System.Drawing.Size(17, 13);
            this.label_NaviPoistionEast.TabIndex = 3;
            this.label_NaviPoistionEast.Text = "E:";
            // 
            // label_NaviOrientation
            // 
            this.label_NaviOrientation.AutoSize = true;
            this.label_NaviOrientation.Location = new System.Drawing.Point(6, 81);
            this.label_NaviOrientation.Name = "label_NaviOrientation";
            this.label_NaviOrientation.Size = new System.Drawing.Size(24, 13);
            this.label_NaviOrientation.TabIndex = 5;
            this.label_NaviOrientation.Text = "Psi:";
            // 
            // tb_NaviOrientation
            // 
            this.tb_NaviOrientation.Location = new System.Drawing.Point(31, 78);
            this.tb_NaviOrientation.Name = "tb_NaviOrientation";
            this.tb_NaviOrientation.ReadOnly = true;
            this.tb_NaviOrientation.Size = new System.Drawing.Size(50, 20);
            this.tb_NaviOrientation.TabIndex = 4;
            this.tb_NaviOrientation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rtb_SerialData
            // 
            this.rtb_SerialData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_SerialData.Location = new System.Drawing.Point(176, 12);
            this.rtb_SerialData.Name = "rtb_SerialData";
            this.rtb_SerialData.Size = new System.Drawing.Size(733, 121);
            this.rtb_SerialData.TabIndex = 6;
            this.rtb_SerialData.Text = "";
            // 
            // gb_ParametersSpeedRun
            // 
            this.gb_ParametersSpeedRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_ParametersSpeedRun.Controls.Add(this.label11);
            this.gb_ParametersSpeedRun.Controls.Add(this.button4);
            this.gb_ParametersSpeedRun.Controls.Add(this.button3);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox16);
            this.gb_ParametersSpeedRun.Controls.Add(this.label10);
            this.gb_ParametersSpeedRun.Controls.Add(this.label9);
            this.gb_ParametersSpeedRun.Controls.Add(this.checkBox6);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox1);
            this.gb_ParametersSpeedRun.Controls.Add(this.checkBox5);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox12);
            this.gb_ParametersSpeedRun.Controls.Add(this.checkBox3);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox11);
            this.gb_ParametersSpeedRun.Controls.Add(this.checkBox4);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox4);
            this.gb_ParametersSpeedRun.Controls.Add(this.checkBox2);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox7);
            this.gb_ParametersSpeedRun.Controls.Add(this.checkBox1);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox5);
            this.gb_ParametersSpeedRun.Controls.Add(this.pictureBox1);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox10);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox2);
            this.gb_ParametersSpeedRun.Controls.Add(this.label8);
            this.gb_ParametersSpeedRun.Controls.Add(this.label5);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox8);
            this.gb_ParametersSpeedRun.Controls.Add(this.label4);
            this.gb_ParametersSpeedRun.Controls.Add(this.button2);
            this.gb_ParametersSpeedRun.Controls.Add(this.label6);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox15);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox6);
            this.gb_ParametersSpeedRun.Controls.Add(this.label1);
            this.gb_ParametersSpeedRun.Controls.Add(this.label3);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox9);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox13);
            this.gb_ParametersSpeedRun.Controls.Add(this.button1);
            this.gb_ParametersSpeedRun.Controls.Add(this.label7);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox14);
            this.gb_ParametersSpeedRun.Controls.Add(this.textBox3);
            this.gb_ParametersSpeedRun.Controls.Add(this.label2);
            this.gb_ParametersSpeedRun.Location = new System.Drawing.Point(456, 222);
            this.gb_ParametersSpeedRun.Name = "gb_ParametersSpeedRun";
            this.gb_ParametersSpeedRun.Size = new System.Drawing.Size(464, 296);
            this.gb_ParametersSpeedRun.TabIndex = 7;
            this.gb_ParametersSpeedRun.TabStop = false;
            this.gb_ParametersSpeedRun.Text = "Speed Run Parameters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "State";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(155, 34);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(50, 20);
            this.textBox5.TabIndex = 43;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_V01
            // 
            this.label_V01.AutoSize = true;
            this.label_V01.Location = new System.Drawing.Point(172, 23);
            this.label_V01.Name = "label_V01";
            this.label_V01.Size = new System.Drawing.Size(14, 13);
            this.label_V01.TabIndex = 26;
            this.label_V01.Text = "V";
            // 
            // label_mm01
            // 
            this.label_mm01.AutoSize = true;
            this.label_mm01.Location = new System.Drawing.Point(161, 43);
            this.label_mm01.Name = "label_mm01";
            this.label_mm01.Size = new System.Drawing.Size(23, 13);
            this.label_mm01.TabIndex = 24;
            this.label_mm01.Text = "mm";
            // 
            // label_A01
            // 
            this.label_A01.AutoSize = true;
            this.label_A01.Location = new System.Drawing.Point(172, 76);
            this.label_A01.Name = "label_A01";
            this.label_A01.Size = new System.Drawing.Size(14, 13);
            this.label_A01.TabIndex = 25;
            this.label_A01.Text = "A";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.splitContainer1.Panel1.Controls.Add(this.pict_TeamLogo);
            this.splitContainer1.Panel1.Controls.Add(this.gb_BoardLineInformations);
            this.splitContainer1.Panel1.Controls.Add(this.gb_BoardMotorInformations);
            this.splitContainer1.Panel1.Controls.Add(this.gb_SteeringWheel);
            this.splitContainer1.Panel1.Controls.Add(this.bg_Encoder);
            this.splitContainer1.Panel1.Controls.Add(this.gb_DistanceSensors);
            this.splitContainer1.Panel1.Controls.Add(this.gb_InertialSensor);
            this.splitContainer1.Panel1.Controls.Add(this.gb_NavigationData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1334, 681);
            this.splitContainer1.SplitterDistance = 407;
            this.splitContainer1.TabIndex = 8;
            // 
            // gb_BoardLineInformations
            // 
            this.gb_BoardLineInformations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_BoardLineInformations.Controls.Add(this.label_mm02);
            this.gb_BoardLineInformations.Controls.Add(this.label_BoardLineSecondLine);
            this.gb_BoardLineInformations.Controls.Add(this.label_mm01);
            this.gb_BoardLineInformations.Controls.Add(this.label_BoardLineMainLine);
            this.gb_BoardLineInformations.Controls.Add(this.label_BoardLineNumberOfLines);
            this.gb_BoardLineInformations.Controls.Add(this.tb_BoardLineSecondLinePos);
            this.gb_BoardLineInformations.Controls.Add(this.tb_BoardLineMainLinePos);
            this.gb_BoardLineInformations.Controls.Add(this.tb_BoardLineLineNumber);
            this.gb_BoardLineInformations.Controls.Add(this.pic_Car2);
            this.gb_BoardLineInformations.Controls.Add(this.trackBar_BoardLineMainLinePos);
            this.gb_BoardLineInformations.Controls.Add(this.trackBar_BoardLineSecondLinePos);
            this.gb_BoardLineInformations.Location = new System.Drawing.Point(218, 453);
            this.gb_BoardLineInformations.Name = "gb_BoardLineInformations";
            this.gb_BoardLineInformations.Size = new System.Drawing.Size(187, 225);
            this.gb_BoardLineInformations.TabIndex = 15;
            this.gb_BoardLineInformations.TabStop = false;
            this.gb_BoardLineInformations.Text = "Line Sensor Data";
            // 
            // label_mm02
            // 
            this.label_mm02.AutoSize = true;
            this.label_mm02.Location = new System.Drawing.Point(161, 64);
            this.label_mm02.Name = "label_mm02";
            this.label_mm02.Size = new System.Drawing.Size(23, 13);
            this.label_mm02.TabIndex = 38;
            this.label_mm02.Text = "mm";
            // 
            // label_BoardLineSecondLine
            // 
            this.label_BoardLineSecondLine.AutoSize = true;
            this.label_BoardLineSecondLine.Location = new System.Drawing.Point(23, 64);
            this.label_BoardLineSecondLine.Name = "label_BoardLineSecondLine";
            this.label_BoardLineSecondLine.Size = new System.Drawing.Size(67, 13);
            this.label_BoardLineSecondLine.TabIndex = 37;
            this.label_BoardLineSecondLine.Text = "2nd line pos:";
            // 
            // label_BoardLineMainLine
            // 
            this.label_BoardLineMainLine.AutoSize = true;
            this.label_BoardLineMainLine.Location = new System.Drawing.Point(22, 42);
            this.label_BoardLineMainLine.Name = "label_BoardLineMainLine";
            this.label_BoardLineMainLine.Size = new System.Drawing.Size(72, 13);
            this.label_BoardLineMainLine.TabIndex = 36;
            this.label_BoardLineMainLine.Text = "Main line pos:";
            // 
            // label_BoardLineNumberOfLines
            // 
            this.label_BoardLineNumberOfLines.AutoSize = true;
            this.label_BoardLineNumberOfLines.Location = new System.Drawing.Point(26, 20);
            this.label_BoardLineNumberOfLines.Name = "label_BoardLineNumberOfLines";
            this.label_BoardLineNumberOfLines.Size = new System.Drawing.Size(68, 13);
            this.label_BoardLineNumberOfLines.TabIndex = 35;
            this.label_BoardLineNumberOfLines.Text = "Line number:";
            // 
            // tb_BoardLineSecondLinePos
            // 
            this.tb_BoardLineSecondLinePos.Location = new System.Drawing.Point(105, 61);
            this.tb_BoardLineSecondLinePos.Name = "tb_BoardLineSecondLinePos";
            this.tb_BoardLineSecondLinePos.ReadOnly = true;
            this.tb_BoardLineSecondLinePos.Size = new System.Drawing.Size(50, 20);
            this.tb_BoardLineSecondLinePos.TabIndex = 34;
            this.tb_BoardLineSecondLinePos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_BoardLineMainLinePos
            // 
            this.tb_BoardLineMainLinePos.Location = new System.Drawing.Point(105, 39);
            this.tb_BoardLineMainLinePos.Name = "tb_BoardLineMainLinePos";
            this.tb_BoardLineMainLinePos.ReadOnly = true;
            this.tb_BoardLineMainLinePos.Size = new System.Drawing.Size(50, 20);
            this.tb_BoardLineMainLinePos.TabIndex = 33;
            this.tb_BoardLineMainLinePos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_BoardLineLineNumber
            // 
            this.tb_BoardLineLineNumber.Location = new System.Drawing.Point(105, 17);
            this.tb_BoardLineLineNumber.Name = "tb_BoardLineLineNumber";
            this.tb_BoardLineLineNumber.ReadOnly = true;
            this.tb_BoardLineLineNumber.Size = new System.Drawing.Size(50, 20);
            this.tb_BoardLineLineNumber.TabIndex = 24;
            this.tb_BoardLineLineNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trackBar_BoardLineMainLinePos
            // 
            this.trackBar_BoardLineMainLinePos.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_BoardLineMainLinePos.Location = new System.Drawing.Point(14, 107);
            this.trackBar_BoardLineMainLinePos.Maximum = 100;
            this.trackBar_BoardLineMainLinePos.Name = "trackBar_BoardLineMainLinePos";
            this.trackBar_BoardLineMainLinePos.Size = new System.Drawing.Size(163, 45);
            this.trackBar_BoardLineMainLinePos.TabIndex = 24;
            this.trackBar_BoardLineMainLinePos.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar_BoardLineSecondLinePos
            // 
            this.trackBar_BoardLineSecondLinePos.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_BoardLineSecondLinePos.Location = new System.Drawing.Point(14, 86);
            this.trackBar_BoardLineSecondLinePos.Maximum = 100;
            this.trackBar_BoardLineSecondLinePos.Name = "trackBar_BoardLineSecondLinePos";
            this.trackBar_BoardLineSecondLinePos.Size = new System.Drawing.Size(163, 45);
            this.trackBar_BoardLineSecondLinePos.TabIndex = 32;
            this.trackBar_BoardLineSecondLinePos.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // gb_BoardMotorInformations
            // 
            this.gb_BoardMotorInformations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_BoardMotorInformations.Controls.Add(this.label_V02);
            this.gb_BoardMotorInformations.Controls.Add(this.label_mA02);
            this.gb_BoardMotorInformations.Controls.Add(this.label_mA01);
            this.gb_BoardMotorInformations.Controls.Add(this.label_BoardMotorServoCurrent);
            this.gb_BoardMotorInformations.Controls.Add(this.label_V01);
            this.gb_BoardMotorInformations.Controls.Add(this.label_A01);
            this.gb_BoardMotorInformations.Controls.Add(this.label_BoardMotorSystemCurrent);
            this.gb_BoardMotorInformations.Controls.Add(this.label_BoardMotorMotorCurrent);
            this.gb_BoardMotorInformations.Controls.Add(this.label_BoardMotorSecondaryBatteryVoltage);
            this.gb_BoardMotorInformations.Controls.Add(this.tb_BoardMotorServoCurrent);
            this.gb_BoardMotorInformations.Controls.Add(this.tb_BoardMotorSystemCurrent);
            this.gb_BoardMotorInformations.Controls.Add(this.tb_BoardMotorMotorCurrent);
            this.gb_BoardMotorInformations.Controls.Add(this.tb_BoardMotorSecondaryBatteryVoltage);
            this.gb_BoardMotorInformations.Controls.Add(this.label_BoardMotorMainBatteryVoltage);
            this.gb_BoardMotorInformations.Controls.Add(this.tb_BoardMotorMainBatteryVoltage);
            this.gb_BoardMotorInformations.Controls.Add(this.trackBar_BoardMotorMainBatteryVoltage);
            this.gb_BoardMotorInformations.Location = new System.Drawing.Point(12, 453);
            this.gb_BoardMotorInformations.Name = "gb_BoardMotorInformations";
            this.gb_BoardMotorInformations.Size = new System.Drawing.Size(199, 225);
            this.gb_BoardMotorInformations.TabIndex = 14;
            this.gb_BoardMotorInformations.TabStop = false;
            this.gb_BoardMotorInformations.Text = "Motor Board Info";
            // 
            // label_V02
            // 
            this.label_V02.AutoSize = true;
            this.label_V02.Location = new System.Drawing.Point(64, 178);
            this.label_V02.Name = "label_V02";
            this.label_V02.Size = new System.Drawing.Size(14, 13);
            this.label_V02.TabIndex = 50;
            this.label_V02.Text = "V";
            // 
            // label_mA02
            // 
            this.label_mA02.AutoSize = true;
            this.label_mA02.Location = new System.Drawing.Point(168, 178);
            this.label_mA02.Name = "label_mA02";
            this.label_mA02.Size = new System.Drawing.Size(22, 13);
            this.label_mA02.TabIndex = 49;
            this.label_mA02.Text = "mA";
            // 
            // label_mA01
            // 
            this.label_mA01.AutoSize = true;
            this.label_mA01.Location = new System.Drawing.Point(168, 127);
            this.label_mA01.Name = "label_mA01";
            this.label_mA01.Size = new System.Drawing.Size(22, 13);
            this.label_mA01.TabIndex = 48;
            this.label_mA01.Text = "mA";
            // 
            // label_BoardMotorServoCurrent
            // 
            this.label_BoardMotorServoCurrent.AutoSize = true;
            this.label_BoardMotorServoCurrent.Location = new System.Drawing.Point(98, 198);
            this.label_BoardMotorServoCurrent.Name = "label_BoardMotorServoCurrent";
            this.label_BoardMotorServoCurrent.Size = new System.Drawing.Size(72, 13);
            this.label_BoardMotorServoCurrent.TabIndex = 47;
            this.label_BoardMotorServoCurrent.Text = "Servo Current";
            // 
            // label_BoardMotorSystemCurrent
            // 
            this.label_BoardMotorSystemCurrent.AutoSize = true;
            this.label_BoardMotorSystemCurrent.Location = new System.Drawing.Point(95, 147);
            this.label_BoardMotorSystemCurrent.Name = "label_BoardMotorSystemCurrent";
            this.label_BoardMotorSystemCurrent.Size = new System.Drawing.Size(78, 13);
            this.label_BoardMotorSystemCurrent.TabIndex = 46;
            this.label_BoardMotorSystemCurrent.Text = "System Current";
            // 
            // label_BoardMotorMotorCurrent
            // 
            this.label_BoardMotorMotorCurrent.AutoSize = true;
            this.label_BoardMotorMotorCurrent.Location = new System.Drawing.Point(98, 96);
            this.label_BoardMotorMotorCurrent.Name = "label_BoardMotorMotorCurrent";
            this.label_BoardMotorMotorCurrent.Size = new System.Drawing.Size(71, 13);
            this.label_BoardMotorMotorCurrent.TabIndex = 45;
            this.label_BoardMotorMotorCurrent.Text = "Motor Current";
            // 
            // label_BoardMotorSecondaryBatteryVoltage
            // 
            this.label_BoardMotorSecondaryBatteryVoltage.AutoSize = true;
            this.label_BoardMotorSecondaryBatteryVoltage.Location = new System.Drawing.Point(95, 43);
            this.label_BoardMotorSecondaryBatteryVoltage.Name = "label_BoardMotorSecondaryBatteryVoltage";
            this.label_BoardMotorSecondaryBatteryVoltage.Size = new System.Drawing.Size(80, 13);
            this.label_BoardMotorSecondaryBatteryVoltage.TabIndex = 44;
            this.label_BoardMotorSecondaryBatteryVoltage.Text = "Backup Battery";
            // 
            // tb_BoardMotorServoCurrent
            // 
            this.tb_BoardMotorServoCurrent.Location = new System.Drawing.Point(108, 175);
            this.tb_BoardMotorServoCurrent.Name = "tb_BoardMotorServoCurrent";
            this.tb_BoardMotorServoCurrent.ReadOnly = true;
            this.tb_BoardMotorServoCurrent.Size = new System.Drawing.Size(50, 20);
            this.tb_BoardMotorServoCurrent.TabIndex = 41;
            this.tb_BoardMotorServoCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_BoardMotorSystemCurrent
            // 
            this.tb_BoardMotorSystemCurrent.Location = new System.Drawing.Point(108, 124);
            this.tb_BoardMotorSystemCurrent.Name = "tb_BoardMotorSystemCurrent";
            this.tb_BoardMotorSystemCurrent.ReadOnly = true;
            this.tb_BoardMotorSystemCurrent.Size = new System.Drawing.Size(50, 20);
            this.tb_BoardMotorSystemCurrent.TabIndex = 40;
            this.tb_BoardMotorSystemCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_BoardMotorMotorCurrent
            // 
            this.tb_BoardMotorMotorCurrent.Location = new System.Drawing.Point(108, 73);
            this.tb_BoardMotorMotorCurrent.Name = "tb_BoardMotorMotorCurrent";
            this.tb_BoardMotorMotorCurrent.ReadOnly = true;
            this.tb_BoardMotorMotorCurrent.Size = new System.Drawing.Size(50, 20);
            this.tb_BoardMotorMotorCurrent.TabIndex = 39;
            this.tb_BoardMotorMotorCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_BoardMotorSecondaryBatteryVoltage
            // 
            this.tb_BoardMotorSecondaryBatteryVoltage.Location = new System.Drawing.Point(108, 20);
            this.tb_BoardMotorSecondaryBatteryVoltage.Name = "tb_BoardMotorSecondaryBatteryVoltage";
            this.tb_BoardMotorSecondaryBatteryVoltage.ReadOnly = true;
            this.tb_BoardMotorSecondaryBatteryVoltage.Size = new System.Drawing.Size(50, 20);
            this.tb_BoardMotorSecondaryBatteryVoltage.TabIndex = 38;
            this.tb_BoardMotorSecondaryBatteryVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_BoardMotorMainBatteryVoltage
            // 
            this.label_BoardMotorMainBatteryVoltage.AutoSize = true;
            this.label_BoardMotorMainBatteryVoltage.Location = new System.Drawing.Point(-1, 198);
            this.label_BoardMotorMainBatteryVoltage.Name = "label_BoardMotorMainBatteryVoltage";
            this.label_BoardMotorMainBatteryVoltage.Size = new System.Drawing.Size(66, 13);
            this.label_BoardMotorMainBatteryVoltage.TabIndex = 37;
            this.label_BoardMotorMainBatteryVoltage.Text = "Main Battery";
            // 
            // tb_BoardMotorMainBatteryVoltage
            // 
            this.tb_BoardMotorMainBatteryVoltage.Location = new System.Drawing.Point(8, 175);
            this.tb_BoardMotorMainBatteryVoltage.Name = "tb_BoardMotorMainBatteryVoltage";
            this.tb_BoardMotorMainBatteryVoltage.ReadOnly = true;
            this.tb_BoardMotorMainBatteryVoltage.Size = new System.Drawing.Size(50, 20);
            this.tb_BoardMotorMainBatteryVoltage.TabIndex = 23;
            this.tb_BoardMotorMainBatteryVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_BoardMotorMainBatteryVoltage.TextChanged += new System.EventHandler(this.tb_BoardMotorMainBatteryVoltage_TextChanged);
            // 
            // trackBar_BoardMotorMainBatteryVoltage
            // 
            this.trackBar_BoardMotorMainBatteryVoltage.Location = new System.Drawing.Point(12, 20);
            this.trackBar_BoardMotorMainBatteryVoltage.Maximum = 100;
            this.trackBar_BoardMotorMainBatteryVoltage.Name = "trackBar_BoardMotorMainBatteryVoltage";
            this.trackBar_BoardMotorMainBatteryVoltage.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_BoardMotorMainBatteryVoltage.Size = new System.Drawing.Size(45, 150);
            this.trackBar_BoardMotorMainBatteryVoltage.TabIndex = 0;
            this.trackBar_BoardMotorMainBatteryVoltage.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_BoardMotorMainBatteryVoltage.Scroll += new System.EventHandler(this.trackBar_BoardMotorMainBatteryVoltage_Scroll);
            // 
            // gb_SteeringWheel
            // 
            this.gb_SteeringWheel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_SteeringWheel.Controls.Add(this.pic_SteeringWheel);
            this.gb_SteeringWheel.Controls.Add(this.label_deg02);
            this.gb_SteeringWheel.Controls.Add(this.tb_SteeringWheelAngle);
            this.gb_SteeringWheel.Controls.Add(this.label_SteeringWheelAngle);
            this.gb_SteeringWheel.Location = new System.Drawing.Point(231, 278);
            this.gb_SteeringWheel.Name = "gb_SteeringWheel";
            this.gb_SteeringWheel.Size = new System.Drawing.Size(173, 169);
            this.gb_SteeringWheel.TabIndex = 13;
            this.gb_SteeringWheel.TabStop = false;
            this.gb_SteeringWheel.Text = "Steering Wheel";
            // 
            // label_deg02
            // 
            this.label_deg02.AutoSize = true;
            this.label_deg02.Location = new System.Drawing.Point(144, 33);
            this.label_deg02.Name = "label_deg02";
            this.label_deg02.Size = new System.Drawing.Size(25, 13);
            this.label_deg02.TabIndex = 39;
            this.label_deg02.Text = "deg";
            // 
            // tb_SteeringWheelAngle
            // 
            this.tb_SteeringWheelAngle.Location = new System.Drawing.Point(86, 30);
            this.tb_SteeringWheelAngle.Name = "tb_SteeringWheelAngle";
            this.tb_SteeringWheelAngle.ReadOnly = true;
            this.tb_SteeringWheelAngle.Size = new System.Drawing.Size(50, 20);
            this.tb_SteeringWheelAngle.TabIndex = 42;
            this.tb_SteeringWheelAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_SteeringWheelAngle
            // 
            this.label_SteeringWheelAngle.AutoSize = true;
            this.label_SteeringWheelAngle.Location = new System.Drawing.Point(10, 33);
            this.label_SteeringWheelAngle.Name = "label_SteeringWheelAngle";
            this.label_SteeringWheelAngle.Size = new System.Drawing.Size(68, 13);
            this.label_SteeringWheelAngle.TabIndex = 48;
            this.label_SteeringWheelAngle.Text = "Wheel Angle";
            // 
            // bg_Encoder
            // 
            this.bg_Encoder.Controls.Add(this.label_EncoderVelocity);
            this.bg_Encoder.Controls.Add(this.tb_EncoderVelocity);
            this.bg_Encoder.Controls.Add(this.label_m_s01);
            this.bg_Encoder.Location = new System.Drawing.Point(134, 12);
            this.bg_Encoder.Name = "bg_Encoder";
            this.bg_Encoder.Size = new System.Drawing.Size(91, 112);
            this.bg_Encoder.TabIndex = 12;
            this.bg_Encoder.TabStop = false;
            this.bg_Encoder.Text = "Encoder";
            // 
            // label_EncoderVelocity
            // 
            this.label_EncoderVelocity.AutoSize = true;
            this.label_EncoderVelocity.Location = new System.Drawing.Point(6, 31);
            this.label_EncoderVelocity.Name = "label_EncoderVelocity";
            this.label_EncoderVelocity.Size = new System.Drawing.Size(44, 13);
            this.label_EncoderVelocity.TabIndex = 49;
            this.label_EncoderVelocity.Text = "Velocity";
            // 
            // tb_EncoderVelocity
            // 
            this.tb_EncoderVelocity.Location = new System.Drawing.Point(6, 48);
            this.tb_EncoderVelocity.Name = "tb_EncoderVelocity";
            this.tb_EncoderVelocity.ReadOnly = true;
            this.tb_EncoderVelocity.Size = new System.Drawing.Size(50, 20);
            this.tb_EncoderVelocity.TabIndex = 31;
            this.tb_EncoderVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_m_s01
            // 
            this.label_m_s01.AutoSize = true;
            this.label_m_s01.Location = new System.Drawing.Point(60, 52);
            this.label_m_s01.Name = "label_m_s01";
            this.label_m_s01.Size = new System.Drawing.Size(25, 13);
            this.label_m_s01.TabIndex = 23;
            this.label_m_s01.Text = "m/s";
            // 
            // gb_DistanceSensors
            // 
            this.gb_DistanceSensors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_DistanceSensors.Controls.Add(this.btn_DistanceCollisionWarningRear);
            this.gb_DistanceSensors.Controls.Add(this.btn_DistanceCollisionWarningFront);
            this.gb_DistanceSensors.Controls.Add(this.btn_DistanceCollisionWarningFrontRight);
            this.gb_DistanceSensors.Controls.Add(this.btn_DistanceCollisionWarningRight);
            this.gb_DistanceSensors.Controls.Add(this.label_DistanceSensorRear);
            this.gb_DistanceSensors.Controls.Add(this.label_DistanceSensorToFRight);
            this.gb_DistanceSensors.Controls.Add(this.label_DistanceSensorToFFrontRight);
            this.gb_DistanceSensors.Controls.Add(this.label_DistanceSensorToFFront);
            this.gb_DistanceSensors.Controls.Add(this.tb_DistanceSensorRear);
            this.gb_DistanceSensors.Controls.Add(this.tb_DistanceSensorRight);
            this.gb_DistanceSensors.Controls.Add(this.tb_DistanceSensorFrontRight);
            this.gb_DistanceSensors.Controls.Add(this.tb_DistanceSensorFront);
            this.gb_DistanceSensors.Controls.Add(this.pic_Car1);
            this.gb_DistanceSensors.Location = new System.Drawing.Point(231, 12);
            this.gb_DistanceSensors.Name = "gb_DistanceSensors";
            this.gb_DistanceSensors.Size = new System.Drawing.Size(173, 260);
            this.gb_DistanceSensors.TabIndex = 11;
            this.gb_DistanceSensors.TabStop = false;
            this.gb_DistanceSensors.Text = "Distance Sensors";
            // 
            // btn_DistanceCollisionWarningRear
            // 
            this.btn_DistanceCollisionWarningRear.Location = new System.Drawing.Point(26, 237);
            this.btn_DistanceCollisionWarningRear.Name = "btn_DistanceCollisionWarningRear";
            this.btn_DistanceCollisionWarningRear.Size = new System.Drawing.Size(15, 15);
            this.btn_DistanceCollisionWarningRear.TabIndex = 30;
            this.btn_DistanceCollisionWarningRear.UseVisualStyleBackColor = true;
            // 
            // btn_DistanceCollisionWarningFront
            // 
            this.btn_DistanceCollisionWarningFront.Location = new System.Drawing.Point(26, 72);
            this.btn_DistanceCollisionWarningFront.Name = "btn_DistanceCollisionWarningFront";
            this.btn_DistanceCollisionWarningFront.Size = new System.Drawing.Size(15, 15);
            this.btn_DistanceCollisionWarningFront.TabIndex = 29;
            this.btn_DistanceCollisionWarningFront.UseVisualStyleBackColor = true;
            // 
            // btn_DistanceCollisionWarningFrontRight
            // 
            this.btn_DistanceCollisionWarningFrontRight.Location = new System.Drawing.Point(70, 97);
            this.btn_DistanceCollisionWarningFrontRight.Name = "btn_DistanceCollisionWarningFrontRight";
            this.btn_DistanceCollisionWarningFrontRight.Size = new System.Drawing.Size(15, 15);
            this.btn_DistanceCollisionWarningFrontRight.TabIndex = 28;
            this.btn_DistanceCollisionWarningFrontRight.UseVisualStyleBackColor = true;
            // 
            // btn_DistanceCollisionWarningRight
            // 
            this.btn_DistanceCollisionWarningRight.Location = new System.Drawing.Point(79, 158);
            this.btn_DistanceCollisionWarningRight.Name = "btn_DistanceCollisionWarningRight";
            this.btn_DistanceCollisionWarningRight.Size = new System.Drawing.Size(15, 15);
            this.btn_DistanceCollisionWarningRight.TabIndex = 27;
            this.btn_DistanceCollisionWarningRight.UseVisualStyleBackColor = true;
            // 
            // label_DistanceSensorRear
            // 
            this.label_DistanceSensorRear.AutoSize = true;
            this.label_DistanceSensorRear.Location = new System.Drawing.Point(67, 218);
            this.label_DistanceSensorRear.Name = "label_DistanceSensorRear";
            this.label_DistanceSensorRear.Size = new System.Drawing.Size(99, 13);
            this.label_DistanceSensorRear.TabIndex = 26;
            this.label_DistanceSensorRear.Text = "Rear (SHARP) [cm]";
            // 
            // label_DistanceSensorToFRight
            // 
            this.label_DistanceSensorToFRight.AutoSize = true;
            this.label_DistanceSensorToFRight.Location = new System.Drawing.Point(103, 159);
            this.label_DistanceSensorToFRight.Name = "label_DistanceSensorToFRight";
            this.label_DistanceSensorToFRight.Size = new System.Drawing.Size(55, 13);
            this.label_DistanceSensorToFRight.TabIndex = 25;
            this.label_DistanceSensorToFRight.Text = "Right [cm]";
            // 
            // label_DistanceSensorToFFrontRight
            // 
            this.label_DistanceSensorToFFrontRight.AutoSize = true;
            this.label_DistanceSensorToFFrontRight.Location = new System.Drawing.Point(76, 58);
            this.label_DistanceSensorToFFrontRight.Name = "label_DistanceSensorToFFrontRight";
            this.label_DistanceSensorToFFrontRight.Size = new System.Drawing.Size(82, 13);
            this.label_DistanceSensorToFFrontRight.TabIndex = 24;
            this.label_DistanceSensorToFFrontRight.Text = "Front-Right [cm]";
            // 
            // label_DistanceSensorToFFront
            // 
            this.label_DistanceSensorToFFront.AutoSize = true;
            this.label_DistanceSensorToFFront.Location = new System.Drawing.Point(10, 32);
            this.label_DistanceSensorToFFront.Name = "label_DistanceSensorToFFront";
            this.label_DistanceSensorToFFront.Size = new System.Drawing.Size(54, 13);
            this.label_DistanceSensorToFFront.TabIndex = 20;
            this.label_DistanceSensorToFFront.Text = "Front [cm]";
            // 
            // tb_DistanceSensorRear
            // 
            this.tb_DistanceSensorRear.Location = new System.Drawing.Point(11, 214);
            this.tb_DistanceSensorRear.Name = "tb_DistanceSensorRear";
            this.tb_DistanceSensorRear.ReadOnly = true;
            this.tb_DistanceSensorRear.Size = new System.Drawing.Size(50, 20);
            this.tb_DistanceSensorRear.TabIndex = 23;
            this.tb_DistanceSensorRear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_DistanceSensorRight
            // 
            this.tb_DistanceSensorRight.Location = new System.Drawing.Point(79, 136);
            this.tb_DistanceSensorRight.Name = "tb_DistanceSensorRight";
            this.tb_DistanceSensorRight.ReadOnly = true;
            this.tb_DistanceSensorRight.Size = new System.Drawing.Size(50, 20);
            this.tb_DistanceSensorRight.TabIndex = 22;
            this.tb_DistanceSensorRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_DistanceSensorFrontRight
            // 
            this.tb_DistanceSensorFrontRight.Location = new System.Drawing.Point(70, 71);
            this.tb_DistanceSensorFrontRight.Name = "tb_DistanceSensorFrontRight";
            this.tb_DistanceSensorFrontRight.ReadOnly = true;
            this.tb_DistanceSensorFrontRight.Size = new System.Drawing.Size(50, 20);
            this.tb_DistanceSensorFrontRight.TabIndex = 21;
            this.tb_DistanceSensorFrontRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_DistanceSensorFront
            // 
            this.tb_DistanceSensorFront.Location = new System.Drawing.Point(11, 48);
            this.tb_DistanceSensorFront.Name = "tb_DistanceSensorFront";
            this.tb_DistanceSensorFront.ReadOnly = true;
            this.tb_DistanceSensorFront.Size = new System.Drawing.Size(50, 20);
            this.tb_DistanceSensorFront.TabIndex = 20;
            this.tb_DistanceSensorFront.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gb_InertialSensor
            // 
            this.gb_InertialSensor.Controls.Add(this.label_InertialSensorAngularAccelerationName);
            this.gb_InertialSensor.Controls.Add(this.label_InertialSensorAccelerationName);
            this.gb_InertialSensor.Controls.Add(this.tb_InertialAngularVelocityPhi);
            this.gb_InertialSensor.Controls.Add(this.tb_InertialAngularVelocityTheta);
            this.gb_InertialSensor.Controls.Add(this.label_rad_s_01);
            this.gb_InertialSensor.Controls.Add(this.label_IntertialAngularVelocityTheta);
            this.gb_InertialSensor.Controls.Add(this.label_m2_s01);
            this.gb_InertialSensor.Controls.Add(this.label_IntertialAngularVelocityPsi);
            this.gb_InertialSensor.Controls.Add(this.tb_InertialAngularVelocityPsi);
            this.gb_InertialSensor.Controls.Add(this.label_IntertialAngularVelocityPhi);
            this.gb_InertialSensor.Controls.Add(this.tb_InertialAccelerationX);
            this.gb_InertialSensor.Controls.Add(this.tb_InertialAccelerationY);
            this.gb_InertialSensor.Controls.Add(this.label_IntertialAccelerationY);
            this.gb_InertialSensor.Controls.Add(this.label_IntertialAccelerationZ);
            this.gb_InertialSensor.Controls.Add(this.tb_InertialAccelerationZ);
            this.gb_InertialSensor.Controls.Add(this.label_IntertialAccelerationX);
            this.gb_InertialSensor.Location = new System.Drawing.Point(12, 130);
            this.gb_InertialSensor.Name = "gb_InertialSensor";
            this.gb_InertialSensor.Size = new System.Drawing.Size(213, 142);
            this.gb_InertialSensor.TabIndex = 10;
            this.gb_InertialSensor.TabStop = false;
            this.gb_InertialSensor.Text = "Inertial Sensor";
            // 
            // label_InertialSensorAngularAccelerationName
            // 
            this.label_InertialSensorAngularAccelerationName.AutoSize = true;
            this.label_InertialSensorAngularAccelerationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InertialSensorAngularAccelerationName.Location = new System.Drawing.Point(131, 18);
            this.label_InertialSensorAngularAccelerationName.Name = "label_InertialSensorAngularAccelerationName";
            this.label_InertialSensorAngularAccelerationName.Size = new System.Drawing.Size(77, 17);
            this.label_InertialSensorAngularAccelerationName.TabIndex = 19;
            this.label_InertialSensorAngularAccelerationName.Text = "Gyroscope";
            // 
            // label_InertialSensorAccelerationName
            // 
            this.label_InertialSensorAccelerationName.AutoSize = true;
            this.label_InertialSensorAccelerationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_InertialSensorAccelerationName.Location = new System.Drawing.Point(6, 18);
            this.label_InertialSensorAccelerationName.Name = "label_InertialSensorAccelerationName";
            this.label_InertialSensorAccelerationName.Size = new System.Drawing.Size(86, 17);
            this.label_InertialSensorAccelerationName.TabIndex = 18;
            this.label_InertialSensorAccelerationName.Text = "Acceleration";
            // 
            // tb_InertialAngularVelocityPhi
            // 
            this.tb_InertialAngularVelocityPhi.Location = new System.Drawing.Point(149, 44);
            this.tb_InertialAngularVelocityPhi.Name = "tb_InertialAngularVelocityPhi";
            this.tb_InertialAngularVelocityPhi.ReadOnly = true;
            this.tb_InertialAngularVelocityPhi.Size = new System.Drawing.Size(50, 20);
            this.tb_InertialAngularVelocityPhi.TabIndex = 12;
            this.tb_InertialAngularVelocityPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_InertialAngularVelocityTheta
            // 
            this.tb_InertialAngularVelocityTheta.Location = new System.Drawing.Point(149, 70);
            this.tb_InertialAngularVelocityTheta.Name = "tb_InertialAngularVelocityTheta";
            this.tb_InertialAngularVelocityTheta.ReadOnly = true;
            this.tb_InertialAngularVelocityTheta.Size = new System.Drawing.Size(50, 20);
            this.tb_InertialAngularVelocityTheta.TabIndex = 13;
            this.tb_InertialAngularVelocityTheta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_rad_s_01
            // 
            this.label_rad_s_01.AutoSize = true;
            this.label_rad_s_01.Location = new System.Drawing.Point(156, 124);
            this.label_rad_s_01.Name = "label_rad_s_01";
            this.label_rad_s_01.Size = new System.Drawing.Size(32, 13);
            this.label_rad_s_01.TabIndex = 22;
            this.label_rad_s_01.Text = "rad/s";
            // 
            // label_IntertialAngularVelocityTheta
            // 
            this.label_IntertialAngularVelocityTheta.AutoSize = true;
            this.label_IntertialAngularVelocityTheta.Location = new System.Drawing.Point(105, 73);
            this.label_IntertialAngularVelocityTheta.Name = "label_IntertialAngularVelocityTheta";
            this.label_IntertialAngularVelocityTheta.Size = new System.Drawing.Size(38, 13);
            this.label_IntertialAngularVelocityTheta.TabIndex = 15;
            this.label_IntertialAngularVelocityTheta.Text = "Theta:";
            // 
            // label_m2_s01
            // 
            this.label_m2_s01.AutoSize = true;
            this.label_m2_s01.Location = new System.Drawing.Point(35, 124);
            this.label_m2_s01.Name = "label_m2_s01";
            this.label_m2_s01.Size = new System.Drawing.Size(31, 13);
            this.label_m2_s01.TabIndex = 21;
            this.label_m2_s01.Text = "m2/s";
            // 
            // label_IntertialAngularVelocityPsi
            // 
            this.label_IntertialAngularVelocityPsi.AutoSize = true;
            this.label_IntertialAngularVelocityPsi.Location = new System.Drawing.Point(119, 99);
            this.label_IntertialAngularVelocityPsi.Name = "label_IntertialAngularVelocityPsi";
            this.label_IntertialAngularVelocityPsi.Size = new System.Drawing.Size(24, 13);
            this.label_IntertialAngularVelocityPsi.TabIndex = 17;
            this.label_IntertialAngularVelocityPsi.Text = "Psi:";
            // 
            // tb_InertialAngularVelocityPsi
            // 
            this.tb_InertialAngularVelocityPsi.Location = new System.Drawing.Point(149, 96);
            this.tb_InertialAngularVelocityPsi.Name = "tb_InertialAngularVelocityPsi";
            this.tb_InertialAngularVelocityPsi.ReadOnly = true;
            this.tb_InertialAngularVelocityPsi.Size = new System.Drawing.Size(50, 20);
            this.tb_InertialAngularVelocityPsi.TabIndex = 16;
            this.tb_InertialAngularVelocityPsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_IntertialAngularVelocityPhi
            // 
            this.label_IntertialAngularVelocityPhi.AutoSize = true;
            this.label_IntertialAngularVelocityPhi.Location = new System.Drawing.Point(118, 47);
            this.label_IntertialAngularVelocityPhi.Name = "label_IntertialAngularVelocityPhi";
            this.label_IntertialAngularVelocityPhi.Size = new System.Drawing.Size(25, 13);
            this.label_IntertialAngularVelocityPhi.TabIndex = 14;
            this.label_IntertialAngularVelocityPhi.Text = "Phi:";
            // 
            // tb_InertialAccelerationX
            // 
            this.tb_InertialAccelerationX.Location = new System.Drawing.Point(28, 44);
            this.tb_InertialAccelerationX.Name = "tb_InertialAccelerationX";
            this.tb_InertialAccelerationX.ReadOnly = true;
            this.tb_InertialAccelerationX.Size = new System.Drawing.Size(50, 20);
            this.tb_InertialAccelerationX.TabIndex = 6;
            this.tb_InertialAccelerationX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_InertialAccelerationY
            // 
            this.tb_InertialAccelerationY.Location = new System.Drawing.Point(28, 70);
            this.tb_InertialAccelerationY.Name = "tb_InertialAccelerationY";
            this.tb_InertialAccelerationY.ReadOnly = true;
            this.tb_InertialAccelerationY.Size = new System.Drawing.Size(50, 20);
            this.tb_InertialAccelerationY.TabIndex = 7;
            this.tb_InertialAccelerationY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_IntertialAccelerationY
            // 
            this.label_IntertialAccelerationY.AutoSize = true;
            this.label_IntertialAccelerationY.Location = new System.Drawing.Point(5, 73);
            this.label_IntertialAccelerationY.Name = "label_IntertialAccelerationY";
            this.label_IntertialAccelerationY.Size = new System.Drawing.Size(17, 13);
            this.label_IntertialAccelerationY.TabIndex = 9;
            this.label_IntertialAccelerationY.Text = "Y:";
            // 
            // label_IntertialAccelerationZ
            // 
            this.label_IntertialAccelerationZ.AutoSize = true;
            this.label_IntertialAccelerationZ.Location = new System.Drawing.Point(5, 99);
            this.label_IntertialAccelerationZ.Name = "label_IntertialAccelerationZ";
            this.label_IntertialAccelerationZ.Size = new System.Drawing.Size(17, 13);
            this.label_IntertialAccelerationZ.TabIndex = 11;
            this.label_IntertialAccelerationZ.Text = "Z:";
            // 
            // tb_InertialAccelerationZ
            // 
            this.tb_InertialAccelerationZ.Location = new System.Drawing.Point(28, 96);
            this.tb_InertialAccelerationZ.Name = "tb_InertialAccelerationZ";
            this.tb_InertialAccelerationZ.ReadOnly = true;
            this.tb_InertialAccelerationZ.Size = new System.Drawing.Size(50, 20);
            this.tb_InertialAccelerationZ.TabIndex = 10;
            this.tb_InertialAccelerationZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_IntertialAccelerationX
            // 
            this.label_IntertialAccelerationX.AutoSize = true;
            this.label_IntertialAccelerationX.Location = new System.Drawing.Point(6, 47);
            this.label_IntertialAccelerationX.Name = "label_IntertialAccelerationX";
            this.label_IntertialAccelerationX.Size = new System.Drawing.Size(17, 13);
            this.label_IntertialAccelerationX.TabIndex = 8;
            this.label_IntertialAccelerationX.Text = "X:";
            // 
            // gb_NavigationData
            // 
            this.gb_NavigationData.Controls.Add(this.label_deg01);
            this.gb_NavigationData.Controls.Add(this.label_m02);
            this.gb_NavigationData.Controls.Add(this.tb_NaviPoistionNorth);
            this.gb_NavigationData.Controls.Add(this.label_m01);
            this.gb_NavigationData.Controls.Add(this.tb_NaviPoistionEast);
            this.gb_NavigationData.Controls.Add(this.label_NaviOrientation);
            this.gb_NavigationData.Controls.Add(this.label_NaviPoistionNorth);
            this.gb_NavigationData.Controls.Add(this.tb_NaviOrientation);
            this.gb_NavigationData.Controls.Add(this.label_NaviPoistionEast);
            this.gb_NavigationData.Location = new System.Drawing.Point(12, 12);
            this.gb_NavigationData.Name = "gb_NavigationData";
            this.gb_NavigationData.Size = new System.Drawing.Size(111, 112);
            this.gb_NavigationData.TabIndex = 9;
            this.gb_NavigationData.TabStop = false;
            this.gb_NavigationData.Text = "Navigation Data";
            // 
            // label_deg01
            // 
            this.label_deg01.AutoSize = true;
            this.label_deg01.Location = new System.Drawing.Point(84, 82);
            this.label_deg01.Name = "label_deg01";
            this.label_deg01.Size = new System.Drawing.Size(25, 13);
            this.label_deg01.TabIndex = 22;
            this.label_deg01.Text = "deg";
            // 
            // label_m02
            // 
            this.label_m02.AutoSize = true;
            this.label_m02.Location = new System.Drawing.Point(86, 55);
            this.label_m02.Name = "label_m02";
            this.label_m02.Size = new System.Drawing.Size(15, 13);
            this.label_m02.TabIndex = 21;
            this.label_m02.Text = "m";
            // 
            // label_m01
            // 
            this.label_m01.AutoSize = true;
            this.label_m01.Location = new System.Drawing.Point(86, 29);
            this.label_m01.Name = "label_m01";
            this.label_m01.Size = new System.Drawing.Size(15, 13);
            this.label_m01.TabIndex = 20;
            this.label_m01.Text = "m";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gb_SerialContainer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gb_Scope);
            this.splitContainer2.Panel2.Controls.Add(this.gb_NaviMap);
            this.splitContainer2.Panel2.Controls.Add(this.gb_MazeRunParameters);
            this.splitContainer2.Panel2.Controls.Add(this.gb_ParametersSpeedRun);
            this.splitContainer2.Size = new System.Drawing.Size(923, 681);
            this.splitContainer2.SplitterDistance = 156;
            this.splitContainer2.TabIndex = 13;
            // 
            // gb_SerialContainer
            // 
            this.gb_SerialContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_SerialContainer.Controls.Add(this.label_Status);
            this.gb_SerialContainer.Controls.Add(this.rtb_SerialData);
            this.gb_SerialContainer.Controls.Add(this.tb_SerialStatusInfo);
            this.gb_SerialContainer.Controls.Add(this.tb_SerialBaude);
            this.gb_SerialContainer.Controls.Add(this.label_SerialBaude);
            this.gb_SerialContainer.Controls.Add(this.btn_Close);
            this.gb_SerialContainer.Controls.Add(this.label_SerialComPort);
            this.gb_SerialContainer.Controls.Add(this.btn_Open);
            this.gb_SerialContainer.Controls.Add(this.cb_SerialComPort);
            this.gb_SerialContainer.Location = new System.Drawing.Point(3, 12);
            this.gb_SerialContainer.Name = "gb_SerialContainer";
            this.gb_SerialContainer.Size = new System.Drawing.Size(915, 141);
            this.gb_SerialContainer.TabIndex = 12;
            this.gb_SerialContainer.TabStop = false;
            this.gb_SerialContainer.Text = "Serial Informations";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(25, 82);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(40, 13);
            this.label_Status.TabIndex = 15;
            this.label_Status.Text = "Status:";
            // 
            // tb_SerialStatusInfo
            // 
            this.tb_SerialStatusInfo.ForeColor = System.Drawing.Color.Red;
            this.tb_SerialStatusInfo.Location = new System.Drawing.Point(87, 79);
            this.tb_SerialStatusInfo.Name = "tb_SerialStatusInfo";
            this.tb_SerialStatusInfo.Size = new System.Drawing.Size(75, 20);
            this.tb_SerialStatusInfo.TabIndex = 14;
            this.tb_SerialStatusInfo.Text = "Closed";
            this.tb_SerialStatusInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_SerialStatusInfo.TextChanged += new System.EventHandler(this.tb_SerialStatusInfo_TextChanged);
            // 
            // tb_SerialBaude
            // 
            this.tb_SerialBaude.Location = new System.Drawing.Point(87, 52);
            this.tb_SerialBaude.Name = "tb_SerialBaude";
            this.tb_SerialBaude.Size = new System.Drawing.Size(75, 20);
            this.tb_SerialBaude.TabIndex = 13;
            this.tb_SerialBaude.Text = "115200";
            this.tb_SerialBaude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_SerialBaude
            // 
            this.label_SerialBaude.AutoSize = true;
            this.label_SerialBaude.Location = new System.Drawing.Point(24, 55);
            this.label_SerialBaude.Name = "label_SerialBaude";
            this.label_SerialBaude.Size = new System.Drawing.Size(41, 13);
            this.label_SerialBaude.TabIndex = 12;
            this.label_SerialBaude.Text = "Baude:";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(87, 110);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label_SerialComPort
            // 
            this.label_SerialComPort.AutoSize = true;
            this.label_SerialComPort.Location = new System.Drawing.Point(31, 26);
            this.label_SerialComPort.Name = "label_SerialComPort";
            this.label_SerialComPort.Size = new System.Drawing.Size(34, 13);
            this.label_SerialComPort.TabIndex = 10;
            this.label_SerialComPort.Text = "COM:";
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(6, 110);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 23);
            this.btn_Open.TabIndex = 9;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // cb_SerialComPort
            // 
            this.cb_SerialComPort.FormattingEnabled = true;
            this.cb_SerialComPort.Location = new System.Drawing.Point(87, 23);
            this.cb_SerialComPort.Name = "cb_SerialComPort";
            this.cb_SerialComPort.Size = new System.Drawing.Size(75, 21);
            this.cb_SerialComPort.TabIndex = 8;
            // 
            // gb_MazeRunParameters
            // 
            this.gb_MazeRunParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_MazeRunParameters.Controls.Add(this.label13);
            this.gb_MazeRunParameters.Controls.Add(this.checkBox10);
            this.gb_MazeRunParameters.Controls.Add(this.checkBox11);
            this.gb_MazeRunParameters.Controls.Add(this.label12);
            this.gb_MazeRunParameters.Controls.Add(this.checkedListBox1);
            this.gb_MazeRunParameters.Controls.Add(this.btn_MazeParametersGetParams);
            this.gb_MazeRunParameters.Controls.Add(this.label_MazeParametersGetValue);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersGetState);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersGetSpeed);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersGetKD);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersGetKP);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersSetState);
            this.gb_MazeRunParameters.Controls.Add(this.btn_MazeParametersSetStateTo);
            this.gb_MazeRunParameters.Controls.Add(this.label_MazeParametersResetStateTo);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersSetStateTo);
            this.gb_MazeRunParameters.Controls.Add(this.label_MazeParametersSetValue);
            this.gb_MazeRunParameters.Controls.Add(this.label_MazeParametersActualValues);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersSetSpeed);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersSetKD);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersSetKP);
            this.gb_MazeRunParameters.Controls.Add(this.label_MazeParametersActualState);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersActualState);
            this.gb_MazeRunParameters.Controls.Add(this.btn_MazeParametersSendParams);
            this.gb_MazeRunParameters.Controls.Add(this.label_MazeParametersSpeed);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersActualSpeed);
            this.gb_MazeRunParameters.Controls.Add(this.label_MazeParametersKD);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersActualKD);
            this.gb_MazeRunParameters.Controls.Add(this.label_MazeParametersKP);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersActualKP);
            this.gb_MazeRunParameters.Location = new System.Drawing.Point(591, -1);
            this.gb_MazeRunParameters.Name = "gb_MazeRunParameters";
            this.gb_MazeRunParameters.Size = new System.Drawing.Size(329, 225);
            this.gb_MazeRunParameters.TabIndex = 8;
            this.gb_MazeRunParameters.TabStop = false;
            this.gb_MazeRunParameters.Text = "Maze Parameters";
            // 
            // btn_MazeParametersGetParams
            // 
            this.btn_MazeParametersGetParams.Location = new System.Drawing.Point(155, 129);
            this.btn_MazeParametersGetParams.Name = "btn_MazeParametersGetParams";
            this.btn_MazeParametersGetParams.Size = new System.Drawing.Size(54, 22);
            this.btn_MazeParametersGetParams.TabIndex = 76;
            this.btn_MazeParametersGetParams.Text = "Get";
            this.btn_MazeParametersGetParams.UseVisualStyleBackColor = true;
            // 
            // label_MazeParametersGetValue
            // 
            this.label_MazeParametersGetValue.AutoSize = true;
            this.label_MazeParametersGetValue.Location = new System.Drawing.Point(155, 18);
            this.label_MazeParametersGetValue.Name = "label_MazeParametersGetValue";
            this.label_MazeParametersGetValue.Size = new System.Drawing.Size(54, 13);
            this.label_MazeParametersGetValue.TabIndex = 75;
            this.label_MazeParametersGetValue.Text = "Get Value";
            // 
            // tb_MazeParametersGetState
            // 
            this.tb_MazeParametersGetState.Location = new System.Drawing.Point(155, 35);
            this.tb_MazeParametersGetState.Name = "tb_MazeParametersGetState";
            this.tb_MazeParametersGetState.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersGetState.TabIndex = 74;
            this.tb_MazeParametersGetState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_MazeParametersGetSpeed
            // 
            this.tb_MazeParametersGetSpeed.Location = new System.Drawing.Point(155, 103);
            this.tb_MazeParametersGetSpeed.Name = "tb_MazeParametersGetSpeed";
            this.tb_MazeParametersGetSpeed.ReadOnly = true;
            this.tb_MazeParametersGetSpeed.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersGetSpeed.TabIndex = 73;
            this.tb_MazeParametersGetSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_MazeParametersGetKD
            // 
            this.tb_MazeParametersGetKD.Location = new System.Drawing.Point(155, 81);
            this.tb_MazeParametersGetKD.Name = "tb_MazeParametersGetKD";
            this.tb_MazeParametersGetKD.ReadOnly = true;
            this.tb_MazeParametersGetKD.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersGetKD.TabIndex = 72;
            this.tb_MazeParametersGetKD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_MazeParametersGetKP
            // 
            this.tb_MazeParametersGetKP.Location = new System.Drawing.Point(155, 58);
            this.tb_MazeParametersGetKP.Name = "tb_MazeParametersGetKP";
            this.tb_MazeParametersGetKP.ReadOnly = true;
            this.tb_MazeParametersGetKP.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersGetKP.TabIndex = 71;
            this.tb_MazeParametersGetKP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_MazeParametersSetState
            // 
            this.tb_MazeParametersSetState.Location = new System.Drawing.Point(99, 35);
            this.tb_MazeParametersSetState.Name = "tb_MazeParametersSetState";
            this.tb_MazeParametersSetState.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersSetState.TabIndex = 70;
            this.tb_MazeParametersSetState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_MazeParametersSetStateTo
            // 
            this.btn_MazeParametersSetStateTo.Location = new System.Drawing.Point(16, 188);
            this.btn_MazeParametersSetStateTo.Name = "btn_MazeParametersSetStateTo";
            this.btn_MazeParametersSetStateTo.Size = new System.Drawing.Size(68, 22);
            this.btn_MazeParametersSetStateTo.TabIndex = 69;
            this.btn_MazeParametersSetStateTo.Text = "Reset";
            this.btn_MazeParametersSetStateTo.UseVisualStyleBackColor = true;
            // 
            // label_MazeParametersResetStateTo
            // 
            this.label_MazeParametersResetStateTo.AutoSize = true;
            this.label_MazeParametersResetStateTo.Location = new System.Drawing.Point(12, 168);
            this.label_MazeParametersResetStateTo.Name = "label_MazeParametersResetStateTo";
            this.label_MazeParametersResetStateTo.Size = new System.Drawing.Size(47, 13);
            this.label_MazeParametersResetStateTo.TabIndex = 68;
            this.label_MazeParametersResetStateTo.Text = "Reset to";
            // 
            // tb_MazeParametersSetStateTo
            // 
            this.tb_MazeParametersSetStateTo.Location = new System.Drawing.Point(61, 165);
            this.tb_MazeParametersSetStateTo.Name = "tb_MazeParametersSetStateTo";
            this.tb_MazeParametersSetStateTo.Size = new System.Drawing.Size(23, 20);
            this.tb_MazeParametersSetStateTo.TabIndex = 67;
            this.tb_MazeParametersSetStateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_MazeParametersSetValue
            // 
            this.label_MazeParametersSetValue.AutoSize = true;
            this.label_MazeParametersSetValue.Location = new System.Drawing.Point(96, 18);
            this.label_MazeParametersSetValue.Name = "label_MazeParametersSetValue";
            this.label_MazeParametersSetValue.Size = new System.Drawing.Size(53, 13);
            this.label_MazeParametersSetValue.TabIndex = 66;
            this.label_MazeParametersSetValue.Text = "Set Value";
            // 
            // label_MazeParametersActualValues
            // 
            this.label_MazeParametersActualValues.AutoSize = true;
            this.label_MazeParametersActualValues.Location = new System.Drawing.Point(51, 18);
            this.label_MazeParametersActualValues.Name = "label_MazeParametersActualValues";
            this.label_MazeParametersActualValues.Size = new System.Drawing.Size(37, 13);
            this.label_MazeParametersActualValues.TabIndex = 65;
            this.label_MazeParametersActualValues.Text = "Actual";
            // 
            // tb_MazeParametersSetSpeed
            // 
            this.tb_MazeParametersSetSpeed.Location = new System.Drawing.Point(99, 103);
            this.tb_MazeParametersSetSpeed.Name = "tb_MazeParametersSetSpeed";
            this.tb_MazeParametersSetSpeed.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersSetSpeed.TabIndex = 63;
            this.tb_MazeParametersSetSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_MazeParametersSetKD
            // 
            this.tb_MazeParametersSetKD.Location = new System.Drawing.Point(99, 80);
            this.tb_MazeParametersSetKD.Name = "tb_MazeParametersSetKD";
            this.tb_MazeParametersSetKD.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersSetKD.TabIndex = 62;
            this.tb_MazeParametersSetKD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_MazeParametersSetKP
            // 
            this.tb_MazeParametersSetKP.Location = new System.Drawing.Point(99, 58);
            this.tb_MazeParametersSetKP.Name = "tb_MazeParametersSetKP";
            this.tb_MazeParametersSetKP.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersSetKP.TabIndex = 61;
            this.tb_MazeParametersSetKP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_MazeParametersActualState
            // 
            this.label_MazeParametersActualState.AutoSize = true;
            this.label_MazeParametersActualState.Location = new System.Drawing.Point(8, 38);
            this.label_MazeParametersActualState.Name = "label_MazeParametersActualState";
            this.label_MazeParametersActualState.Size = new System.Drawing.Size(32, 13);
            this.label_MazeParametersActualState.TabIndex = 60;
            this.label_MazeParametersActualState.Text = "State";
            // 
            // tb_MazeParametersActualState
            // 
            this.tb_MazeParametersActualState.Location = new System.Drawing.Point(43, 35);
            this.tb_MazeParametersActualState.Name = "tb_MazeParametersActualState";
            this.tb_MazeParametersActualState.ReadOnly = true;
            this.tb_MazeParametersActualState.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersActualState.TabIndex = 59;
            this.tb_MazeParametersActualState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_MazeParametersSendParams
            // 
            this.btn_MazeParametersSendParams.Location = new System.Drawing.Point(99, 129);
            this.btn_MazeParametersSendParams.Name = "btn_MazeParametersSendParams";
            this.btn_MazeParametersSendParams.Size = new System.Drawing.Size(50, 22);
            this.btn_MazeParametersSendParams.TabIndex = 58;
            this.btn_MazeParametersSendParams.Text = "Send";
            this.btn_MazeParametersSendParams.UseVisualStyleBackColor = true;
            // 
            // label_MazeParametersSpeed
            // 
            this.label_MazeParametersSpeed.AutoSize = true;
            this.label_MazeParametersSpeed.Location = new System.Drawing.Point(2, 106);
            this.label_MazeParametersSpeed.Name = "label_MazeParametersSpeed";
            this.label_MazeParametersSpeed.Size = new System.Drawing.Size(38, 13);
            this.label_MazeParametersSpeed.TabIndex = 55;
            this.label_MazeParametersSpeed.Text = "Speed";
            // 
            // tb_MazeParametersActualSpeed
            // 
            this.tb_MazeParametersActualSpeed.Location = new System.Drawing.Point(43, 103);
            this.tb_MazeParametersActualSpeed.Name = "tb_MazeParametersActualSpeed";
            this.tb_MazeParametersActualSpeed.ReadOnly = true;
            this.tb_MazeParametersActualSpeed.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersActualSpeed.TabIndex = 54;
            this.tb_MazeParametersActualSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_MazeParametersKD
            // 
            this.label_MazeParametersKD.AutoSize = true;
            this.label_MazeParametersKD.Location = new System.Drawing.Point(12, 83);
            this.label_MazeParametersKD.Name = "label_MazeParametersKD";
            this.label_MazeParametersKD.Size = new System.Drawing.Size(28, 13);
            this.label_MazeParametersKD.TabIndex = 53;
            this.label_MazeParametersKD.Text = "K_D";
            // 
            // tb_MazeParametersActualKD
            // 
            this.tb_MazeParametersActualKD.Location = new System.Drawing.Point(43, 80);
            this.tb_MazeParametersActualKD.Name = "tb_MazeParametersActualKD";
            this.tb_MazeParametersActualKD.ReadOnly = true;
            this.tb_MazeParametersActualKD.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersActualKD.TabIndex = 52;
            this.tb_MazeParametersActualKD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_MazeParametersKP
            // 
            this.label_MazeParametersKP.AutoSize = true;
            this.label_MazeParametersKP.Location = new System.Drawing.Point(13, 61);
            this.label_MazeParametersKP.Name = "label_MazeParametersKP";
            this.label_MazeParametersKP.Size = new System.Drawing.Size(27, 13);
            this.label_MazeParametersKP.TabIndex = 51;
            this.label_MazeParametersKP.Text = "K_P";
            // 
            // tb_MazeParametersActualKP
            // 
            this.tb_MazeParametersActualKP.Location = new System.Drawing.Point(43, 58);
            this.tb_MazeParametersActualKP.Name = "tb_MazeParametersActualKP";
            this.tb_MazeParametersActualKP.ReadOnly = true;
            this.tb_MazeParametersActualKP.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersActualKP.TabIndex = 50;
            this.tb_MazeParametersActualKP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pict_TeamLogo
            // 
            this.pict_TeamLogo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pict_TeamLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pict_TeamLogo.Image = global::OrientApp.Properties.Resources.Névtelen;
            this.pict_TeamLogo.InitialImage = global::OrientApp.Properties.Resources.Névtelen;
            this.pict_TeamLogo.Location = new System.Drawing.Point(45, 288);
            this.pict_TeamLogo.Name = "pict_TeamLogo";
            this.pict_TeamLogo.Size = new System.Drawing.Size(155, 155);
            this.pict_TeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_TeamLogo.TabIndex = 16;
            this.pict_TeamLogo.TabStop = false;
            this.pict_TeamLogo.Click += new System.EventHandler(this.pict_TeamLogo_Click);
            // 
            // pic_Car2
            // 
            this.pic_Car2.Image = global::OrientApp.Properties.Resources.car_007_5121;
            this.pic_Car2.Location = new System.Drawing.Point(71, 130);
            this.pic_Car2.Name = "pic_Car2";
            this.pic_Car2.Size = new System.Drawing.Size(51, 100);
            this.pic_Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Car2.TabIndex = 31;
            this.pic_Car2.TabStop = false;
            // 
            // pic_SteeringWheel
            // 
            this.pic_SteeringWheel.Image = global::OrientApp.Properties.Resources.automotive_steering_wheel2_5121;
            this.pic_SteeringWheel.InitialImage = global::OrientApp.Properties.Resources.automotive_steering_wheel2_5121;
            this.pic_SteeringWheel.Location = new System.Drawing.Point(49, 69);
            this.pic_SteeringWheel.Name = "pic_SteeringWheel";
            this.pic_SteeringWheel.Size = new System.Drawing.Size(80, 80);
            this.pic_SteeringWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_SteeringWheel.TabIndex = 49;
            this.pic_SteeringWheel.TabStop = false;
            // 
            // pic_Car1
            // 
            this.pic_Car1.Image = global::OrientApp.Properties.Resources.car_007_5121;
            this.pic_Car1.Location = new System.Drawing.Point(10, 99);
            this.pic_Car1.Name = "pic_Car1";
            this.pic_Car1.Size = new System.Drawing.Size(51, 100);
            this.pic_Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Car1.TabIndex = 12;
            this.pic_Car1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::OrientApp.Properties.Resources.SpeedRunMap_mini;
            this.pictureBox1.Location = new System.Drawing.Point(215, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Set Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Get Value";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 54;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 55;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 58;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 20);
            this.textBox4.TabIndex = 57;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(155, 56);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(50, 20);
            this.textBox6.TabIndex = 56;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(43, 78);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(50, 20);
            this.textBox7.TabIndex = 61;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(99, 78);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(50, 20);
            this.textBox8.TabIndex = 60;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(155, 78);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(50, 20);
            this.textBox9.TabIndex = 59;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(43, 100);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(50, 20);
            this.textBox10.TabIndex = 64;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(99, 100);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(50, 20);
            this.textBox11.TabIndex = 63;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(155, 100);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(50, 20);
            this.textBox12.TabIndex = 62;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(44, 123);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(50, 20);
            this.textBox13.TabIndex = 67;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(99, 123);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(50, 20);
            this.textBox14.TabIndex = 66;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(155, 123);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(50, 20);
            this.textBox15.TabIndex = 65;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "P";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "K_P";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "K_D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Speed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 72;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 73;
            this.button2.Text = "Get";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 218);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 74;
            this.checkBox1.Text = "Parade Lap";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 233);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 17);
            this.checkBox2.TabIndex = 75;
            this.checkBox2.Text = "Overtaking";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 263);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(53, 17);
            this.checkBox3.TabIndex = 77;
            this.checkBox3.Text = "Lap 2";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 248);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(53, 17);
            this.checkBox4.TabIndex = 76;
            this.checkBox4.Text = "Lap 1";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 278);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(53, 17);
            this.checkBox5.TabIndex = 78;
            this.checkBox5.Text = "Lap 3";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 176);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(98, 17);
            this.checkBox6.TabIndex = 79;
            this.checkBox6.Text = "Try to overtake";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(3, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 80;
            this.label9.Text = "Main State Machine";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(3, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Settings";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(183, 242);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(21, 20);
            this.textBox16.TabIndex = 82;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 83;
            this.button3.Text = "Soft Reset";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(127, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 23);
            this.button4.TabIndex = 84;
            this.button4.Text = "Hard Reset";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(132, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Reset to";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1 st",
            "2 nd",
            "3 rd",
            "4 th",
            "5 th",
            "6 th",
            "7 th",
            "8 th",
            "9 th",
            "10 th",
            "11 th",
            "12 th"});
            this.checkedListBox1.Location = new System.Drawing.Point(239, 35);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(54, 184);
            this.checkedListBox1.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(222, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 86;
            this.label12.Text = "Maze Segments";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(107, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 92;
            this.label13.Text = "Main State Machine";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(110, 196);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(74, 17);
            this.checkBox10.TabIndex = 88;
            this.checkBox10.Text = "Inclination";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(110, 181);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(73, 17);
            this.checkBox11.TabIndex = 87;
            this.checkBox11.Text = "Discovery";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // gb_NaviMap
            // 
            this.gb_NaviMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_NaviMap.Location = new System.Drawing.Point(3, 222);
            this.gb_NaviMap.Name = "gb_NaviMap";
            this.gb_NaviMap.Size = new System.Drawing.Size(450, 296);
            this.gb_NaviMap.TabIndex = 9;
            this.gb_NaviMap.TabStop = false;
            this.gb_NaviMap.Text = "Navigation Map";
            // 
            // gb_Scope
            // 
            this.gb_Scope.Location = new System.Drawing.Point(3, 0);
            this.gb_Scope.Name = "gb_Scope";
            this.gb_Scope.Size = new System.Drawing.Size(584, 224);
            this.gb_Scope.TabIndex = 10;
            this.gb_Scope.TabStop = false;
            this.gb_Scope.Text = "Scope";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 681);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Car Dignostics Tool Evo";
            this.gb_ParametersSpeedRun.ResumeLayout(false);
            this.gb_ParametersSpeedRun.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gb_BoardLineInformations.ResumeLayout(false);
            this.gb_BoardLineInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BoardLineMainLinePos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BoardLineSecondLinePos)).EndInit();
            this.gb_BoardMotorInformations.ResumeLayout(false);
            this.gb_BoardMotorInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BoardMotorMainBatteryVoltage)).EndInit();
            this.gb_SteeringWheel.ResumeLayout(false);
            this.gb_SteeringWheel.PerformLayout();
            this.bg_Encoder.ResumeLayout(false);
            this.bg_Encoder.PerformLayout();
            this.gb_DistanceSensors.ResumeLayout(false);
            this.gb_DistanceSensors.PerformLayout();
            this.gb_InertialSensor.ResumeLayout(false);
            this.gb_InertialSensor.PerformLayout();
            this.gb_NavigationData.ResumeLayout(false);
            this.gb_NavigationData.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gb_SerialContainer.ResumeLayout(false);
            this.gb_SerialContainer.PerformLayout();
            this.gb_MazeRunParameters.ResumeLayout(false);
            this.gb_MazeRunParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_TeamLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SteeringWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox tb_NaviPoistionNorth;
        private System.Windows.Forms.TextBox tb_NaviPoistionEast;
        private System.Windows.Forms.Label label_NaviPoistionNorth;
        private System.Windows.Forms.Label label_NaviPoistionEast;
        private System.Windows.Forms.Label label_NaviOrientation;
        private System.Windows.Forms.TextBox tb_NaviOrientation;
        private System.Windows.Forms.RichTextBox rtb_SerialData;
        private System.Windows.Forms.GroupBox gb_ParametersSpeedRun;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gb_NavigationData;
        private System.Windows.Forms.ComboBox cb_SerialComPort;
        private System.Windows.Forms.Label label_SerialComPort;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.GroupBox gb_SerialContainer;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TextBox tb_SerialStatusInfo;
        private System.Windows.Forms.TextBox tb_SerialBaude;
        private System.Windows.Forms.Label label_SerialBaude;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gb_DistanceSensors;
        private System.Windows.Forms.GroupBox gb_InertialSensor;
        private System.Windows.Forms.Label label_InertialSensorAngularAccelerationName;
        private System.Windows.Forms.Label label_InertialSensorAccelerationName;
        private System.Windows.Forms.TextBox tb_InertialAngularVelocityPhi;
        private System.Windows.Forms.TextBox tb_InertialAngularVelocityTheta;
        private System.Windows.Forms.Label label_IntertialAngularVelocityTheta;
        private System.Windows.Forms.Label label_IntertialAngularVelocityPsi;
        private System.Windows.Forms.TextBox tb_InertialAngularVelocityPsi;
        private System.Windows.Forms.Label label_IntertialAngularVelocityPhi;
        private System.Windows.Forms.TextBox tb_InertialAccelerationX;
        private System.Windows.Forms.TextBox tb_InertialAccelerationY;
        private System.Windows.Forms.Label label_IntertialAccelerationY;
        private System.Windows.Forms.Label label_IntertialAccelerationZ;
        private System.Windows.Forms.TextBox tb_InertialAccelerationZ;
        private System.Windows.Forms.Label label_IntertialAccelerationX;
        private System.Windows.Forms.PictureBox pic_Car1;
        private System.Windows.Forms.Button btn_DistanceCollisionWarningRight;
        private System.Windows.Forms.Label label_DistanceSensorRear;
        private System.Windows.Forms.Label label_DistanceSensorToFRight;
        private System.Windows.Forms.Label label_DistanceSensorToFFrontRight;
        private System.Windows.Forms.Label label_DistanceSensorToFFront;
        private System.Windows.Forms.TextBox tb_DistanceSensorRear;
        private System.Windows.Forms.TextBox tb_DistanceSensorRight;
        private System.Windows.Forms.TextBox tb_DistanceSensorFrontRight;
        private System.Windows.Forms.TextBox tb_DistanceSensorFront;
        private System.Windows.Forms.Button btn_DistanceCollisionWarningRear;
        private System.Windows.Forms.Button btn_DistanceCollisionWarningFront;
        private System.Windows.Forms.Button btn_DistanceCollisionWarningFrontRight;
        private System.Windows.Forms.Label label_V01;
        private System.Windows.Forms.Label label_mm01;
        private System.Windows.Forms.Label label_A01;
        private System.Windows.Forms.GroupBox bg_Encoder;
        private System.Windows.Forms.TextBox tb_EncoderVelocity;
        private System.Windows.Forms.Label label_m_s01;
        private System.Windows.Forms.Label label_rad_s_01;
        private System.Windows.Forms.Label label_m2_s01;
        private System.Windows.Forms.Label label_deg01;
        private System.Windows.Forms.Label label_m02;
        private System.Windows.Forms.Label label_m01;
        private System.Windows.Forms.GroupBox gb_SteeringWheel;
        private System.Windows.Forms.GroupBox gb_BoardLineInformations;
        private System.Windows.Forms.GroupBox gb_BoardMotorInformations;
        private System.Windows.Forms.TextBox tb_BoardMotorMainBatteryVoltage;
        private System.Windows.Forms.TrackBar trackBar_BoardMotorMainBatteryVoltage;
        private System.Windows.Forms.TrackBar trackBar_BoardLineMainLinePos;
        private System.Windows.Forms.PictureBox pic_Car2;
        private System.Windows.Forms.Label label_BoardLineSecondLine;
        private System.Windows.Forms.Label label_BoardLineMainLine;
        private System.Windows.Forms.Label label_BoardLineNumberOfLines;
        private System.Windows.Forms.TextBox tb_BoardLineSecondLinePos;
        private System.Windows.Forms.TextBox tb_BoardLineMainLinePos;
        private System.Windows.Forms.TextBox tb_BoardLineLineNumber;
        private System.Windows.Forms.TrackBar trackBar_BoardLineSecondLinePos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_SteeringWheelAngle;
        private System.Windows.Forms.TextBox tb_SteeringWheelAngle;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label_BoardMotorServoCurrent;
        private System.Windows.Forms.Label label_BoardMotorSystemCurrent;
        private System.Windows.Forms.Label label_BoardMotorMotorCurrent;
        private System.Windows.Forms.Label label_BoardMotorSecondaryBatteryVoltage;
        private System.Windows.Forms.TextBox tb_BoardMotorServoCurrent;
        private System.Windows.Forms.TextBox tb_BoardMotorSystemCurrent;
        private System.Windows.Forms.TextBox tb_BoardMotorMotorCurrent;
        private System.Windows.Forms.TextBox tb_BoardMotorSecondaryBatteryVoltage;
        private System.Windows.Forms.Label label_BoardMotorMainBatteryVoltage;
        private System.Windows.Forms.Label label_mA01;
        private System.Windows.Forms.Label label_mA02;
        private System.Windows.Forms.Label label_V02;
        private System.Windows.Forms.Label label_mm02;
        private System.Windows.Forms.GroupBox gb_MazeRunParameters;
        private System.Windows.Forms.Label label_MazeParametersActualState;
        private System.Windows.Forms.TextBox tb_MazeParametersActualState;
        private System.Windows.Forms.Button btn_MazeParametersSendParams;
        private System.Windows.Forms.Label label_MazeParametersSpeed;
        private System.Windows.Forms.TextBox tb_MazeParametersActualSpeed;
        private System.Windows.Forms.Label label_MazeParametersKD;
        private System.Windows.Forms.TextBox tb_MazeParametersActualKD;
        private System.Windows.Forms.Label label_MazeParametersKP;
        private System.Windows.Forms.TextBox tb_MazeParametersActualKP;
        private System.Windows.Forms.Button btn_MazeParametersSetStateTo;
        private System.Windows.Forms.Label label_MazeParametersResetStateTo;
        private System.Windows.Forms.TextBox tb_MazeParametersSetStateTo;
        private System.Windows.Forms.Label label_MazeParametersSetValue;
        private System.Windows.Forms.Label label_MazeParametersActualValues;
        private System.Windows.Forms.TextBox tb_MazeParametersSetSpeed;
        private System.Windows.Forms.TextBox tb_MazeParametersSetKD;
        private System.Windows.Forms.TextBox tb_MazeParametersSetKP;
        private System.Windows.Forms.TextBox tb_MazeParametersSetState;
        private System.Windows.Forms.Label label_EncoderVelocity;
        private System.Windows.Forms.PictureBox pict_TeamLogo;
        private System.Windows.Forms.PictureBox pic_SteeringWheel;
        private System.Windows.Forms.Label label_deg02;
        private System.Windows.Forms.TextBox tb_MazeParametersGetSpeed;
        private System.Windows.Forms.TextBox tb_MazeParametersGetKD;
        private System.Windows.Forms.TextBox tb_MazeParametersGetKP;
        private System.Windows.Forms.Button btn_MazeParametersGetParams;
        private System.Windows.Forms.Label label_MazeParametersGetValue;
        private System.Windows.Forms.TextBox tb_MazeParametersGetState;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox gb_NaviMap;
        private System.Windows.Forms.GroupBox gb_Scope;
    }
}

