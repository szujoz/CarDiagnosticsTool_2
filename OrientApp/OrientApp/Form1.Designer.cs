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
            this.label_SpeedRunSoftResetTo = new System.Windows.Forms.Label();
            this.btn_SpeedRunHardReset = new System.Windows.Forms.Button();
            this.btn_SpeedRunSoftReset = new System.Windows.Forms.Button();
            this.tb_SpeedRunSoftResetTo = new System.Windows.Forms.TextBox();
            this.btn_SpeedRunSettings = new System.Windows.Forms.Label();
            this.label_SpeedRunMainSM = new System.Windows.Forms.Label();
            this.checkB_SpeedRunTryOvertake = new System.Windows.Forms.CheckBox();
            this.tb_SpeedRunParametersSetState = new System.Windows.Forms.TextBox();
            this.checkB_SpeedRunMainSMLap3 = new System.Windows.Forms.CheckBox();
            this.tb_SpeedRunParametersGetKd = new System.Windows.Forms.TextBox();
            this.checkB_SpeedRunMainSMLap2 = new System.Windows.Forms.CheckBox();
            this.tb_SpeedRunParametersSetKd = new System.Windows.Forms.TextBox();
            this.checkB_SpeedRunMainSMLap1 = new System.Windows.Forms.CheckBox();
            this.tb_SpeedRunParametersSetP = new System.Windows.Forms.TextBox();
            this.checkB_SpeedRunMainSMOvertaking = new System.Windows.Forms.CheckBox();
            this.tb_SpeedRunParametersActualKp = new System.Windows.Forms.TextBox();
            this.checkB_SpeedRunMainSMParadeLap = new System.Windows.Forms.CheckBox();
            this.tb_SpeedRunParametersGetState = new System.Windows.Forms.TextBox();
            this.pic_SpeedRunMap = new System.Windows.Forms.PictureBox();
            this.tb_SpeedRunParametersActualKd = new System.Windows.Forms.TextBox();
            this.tb_SpeedRunParametersActualState = new System.Windows.Forms.TextBox();
            this.label_SpeedRunParametersState = new System.Windows.Forms.Label();
            this.label_SpeedRunParametersKp = new System.Windows.Forms.Label();
            this.tb_SpeedRunParametersSetKp = new System.Windows.Forms.TextBox();
            this.label_SpeedRunParametersP = new System.Windows.Forms.Label();
            this.btn_SpeedRunGet = new System.Windows.Forms.Button();
            this.label_SpeedRunParametersKd = new System.Windows.Forms.Label();
            this.tb_SpeedRunParametersGetSpeed = new System.Windows.Forms.TextBox();
            this.tb_SpeedRunParametersGetP = new System.Windows.Forms.TextBox();
            this.label_SpeedRunParametersActual = new System.Windows.Forms.Label();
            this.label_SpeedRunParametersGetValue = new System.Windows.Forms.Label();
            this.tb_SpeedRunParametersGetKp = new System.Windows.Forms.TextBox();
            this.tb_SpeedRunParametersActualSpeed = new System.Windows.Forms.TextBox();
            this.btn_SpeedRunSet = new System.Windows.Forms.Button();
            this.label_SpeedRunParametersSpeed = new System.Windows.Forms.Label();
            this.tb_SpeedRunParametersSetSpeed = new System.Windows.Forms.TextBox();
            this.tb_SpeedRunParametersActualP = new System.Windows.Forms.TextBox();
            this.label_SpeedRunParametersSetValue = new System.Windows.Forms.Label();
            this.label_V01 = new System.Windows.Forms.Label();
            this.label_mm01 = new System.Windows.Forms.Label();
            this.label_A01 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pict_TeamLogo = new System.Windows.Forms.PictureBox();
            this.gb_BoardLineInformations = new System.Windows.Forms.GroupBox();
            this.label_mm02 = new System.Windows.Forms.Label();
            this.label_BoardLineSecondLine = new System.Windows.Forms.Label();
            this.label_BoardLineMainLine = new System.Windows.Forms.Label();
            this.label_BoardLineNumberOfLines = new System.Windows.Forms.Label();
            this.tb_BoardLineSecondLinePos = new System.Windows.Forms.TextBox();
            this.tb_BoardLineMainLinePos = new System.Windows.Forms.TextBox();
            this.tb_BoardLineLineNumber = new System.Windows.Forms.TextBox();
            this.pic_Car2 = new System.Windows.Forms.PictureBox();
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
            this.pic_SteeringWheel = new System.Windows.Forms.PictureBox();
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
            this.pic_Car1 = new System.Windows.Forms.PictureBox();
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
            this.gb_Scope = new System.Windows.Forms.GroupBox();
            this.gb_NaviMap = new System.Windows.Forms.GroupBox();
            this.gb_MazeRunParameters = new System.Windows.Forms.GroupBox();
            this.label_MazeMainStateMachine = new System.Windows.Forms.Label();
            this.checkB_MazeMainSMInclination = new System.Windows.Forms.CheckBox();
            this.checkB_MazeMainSMDiscovery = new System.Windows.Forms.CheckBox();
            this.label_MazeSegmentList = new System.Windows.Forms.Label();
            this.checkListB_MazeSegmentList = new System.Windows.Forms.CheckedListBox();
            this.btn_MazeParametersGetParams = new System.Windows.Forms.Button();
            this.label_MazeParametersGetValue = new System.Windows.Forms.Label();
            this.tb_MazeParametersGetState = new System.Windows.Forms.TextBox();
            this.tb_MazeParametersGetSpeed = new System.Windows.Forms.TextBox();
            this.tb_MazeParametersGetKD = new System.Windows.Forms.TextBox();
            this.tb_MazeParametersGetKP = new System.Windows.Forms.TextBox();
            this.tb_MazeParametersSetState = new System.Windows.Forms.TextBox();
            this.btn_MazeParametersSetStateTo = new System.Windows.Forms.Button();
            this.label_MazeParametersResetStateTo = new System.Windows.Forms.Label();
            this.tb_MazeParametersResetStateTo = new System.Windows.Forms.TextBox();
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
            this.gb_ParametersSpeedRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SpeedRunMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_TeamLogo)).BeginInit();
            this.gb_BoardLineInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BoardLineMainLinePos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BoardLineSecondLinePos)).BeginInit();
            this.gb_BoardMotorInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BoardMotorMainBatteryVoltage)).BeginInit();
            this.gb_SteeringWheel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SteeringWheel)).BeginInit();
            this.bg_Encoder.SuspendLayout();
            this.gb_DistanceSensors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Car1)).BeginInit();
            this.gb_InertialSensor.SuspendLayout();
            this.gb_NavigationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gb_SerialContainer.SuspendLayout();
            this.gb_MazeRunParameters.SuspendLayout();
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
            this.gb_ParametersSpeedRun.Controls.Add(this.label_SpeedRunSoftResetTo);
            this.gb_ParametersSpeedRun.Controls.Add(this.btn_SpeedRunHardReset);
            this.gb_ParametersSpeedRun.Controls.Add(this.btn_SpeedRunSoftReset);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunSoftResetTo);
            this.gb_ParametersSpeedRun.Controls.Add(this.btn_SpeedRunSettings);
            this.gb_ParametersSpeedRun.Controls.Add(this.label_SpeedRunMainSM);
            this.gb_ParametersSpeedRun.Controls.Add(this.checkB_SpeedRunTryOvertake);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersSetState);
            this.gb_ParametersSpeedRun.Controls.Add(this.checkB_SpeedRunMainSMLap3);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersGetKd);
            this.gb_ParametersSpeedRun.Controls.Add(this.checkB_SpeedRunMainSMLap2);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersSetKd);
            this.gb_ParametersSpeedRun.Controls.Add(this.checkB_SpeedRunMainSMLap1);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersSetP);
            this.gb_ParametersSpeedRun.Controls.Add(this.checkB_SpeedRunMainSMOvertaking);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersActualKp);
            this.gb_ParametersSpeedRun.Controls.Add(this.checkB_SpeedRunMainSMParadeLap);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersGetState);
            this.gb_ParametersSpeedRun.Controls.Add(this.pic_SpeedRunMap);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersActualKd);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersActualState);
            this.gb_ParametersSpeedRun.Controls.Add(this.label_SpeedRunParametersState);
            this.gb_ParametersSpeedRun.Controls.Add(this.label_SpeedRunParametersKp);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersSetKp);
            this.gb_ParametersSpeedRun.Controls.Add(this.label_SpeedRunParametersP);
            this.gb_ParametersSpeedRun.Controls.Add(this.btn_SpeedRunGet);
            this.gb_ParametersSpeedRun.Controls.Add(this.label_SpeedRunParametersKd);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersGetSpeed);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersGetP);
            this.gb_ParametersSpeedRun.Controls.Add(this.label_SpeedRunParametersActual);
            this.gb_ParametersSpeedRun.Controls.Add(this.label_SpeedRunParametersGetValue);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersGetKp);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersActualSpeed);
            this.gb_ParametersSpeedRun.Controls.Add(this.btn_SpeedRunSet);
            this.gb_ParametersSpeedRun.Controls.Add(this.label_SpeedRunParametersSpeed);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersSetSpeed);
            this.gb_ParametersSpeedRun.Controls.Add(this.tb_SpeedRunParametersActualP);
            this.gb_ParametersSpeedRun.Controls.Add(this.label_SpeedRunParametersSetValue);
            this.gb_ParametersSpeedRun.Location = new System.Drawing.Point(456, 222);
            this.gb_ParametersSpeedRun.Name = "gb_ParametersSpeedRun";
            this.gb_ParametersSpeedRun.Size = new System.Drawing.Size(464, 296);
            this.gb_ParametersSpeedRun.TabIndex = 7;
            this.gb_ParametersSpeedRun.TabStop = false;
            this.gb_ParametersSpeedRun.Text = "Speed Run Parameters";
            // 
            // label_SpeedRunSoftResetTo
            // 
            this.label_SpeedRunSoftResetTo.AutoSize = true;
            this.label_SpeedRunSoftResetTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_SpeedRunSoftResetTo.Location = new System.Drawing.Point(132, 246);
            this.label_SpeedRunSoftResetTo.Name = "label_SpeedRunSoftResetTo";
            this.label_SpeedRunSoftResetTo.Size = new System.Drawing.Size(47, 13);
            this.label_SpeedRunSoftResetTo.TabIndex = 85;
            this.label_SpeedRunSoftResetTo.Text = "Reset to";
            // 
            // btn_SpeedRunHardReset
            // 
            this.btn_SpeedRunHardReset.Location = new System.Drawing.Point(127, 198);
            this.btn_SpeedRunHardReset.Name = "btn_SpeedRunHardReset";
            this.btn_SpeedRunHardReset.Size = new System.Drawing.Size(77, 23);
            this.btn_SpeedRunHardReset.TabIndex = 84;
            this.btn_SpeedRunHardReset.Text = "Hard Reset";
            this.btn_SpeedRunHardReset.UseVisualStyleBackColor = true;
            this.btn_SpeedRunHardReset.Click += new System.EventHandler(this.btn_SpeedRunHardReset_Click);
            // 
            // btn_SpeedRunSoftReset
            // 
            this.btn_SpeedRunSoftReset.Location = new System.Drawing.Point(121, 267);
            this.btn_SpeedRunSoftReset.Name = "btn_SpeedRunSoftReset";
            this.btn_SpeedRunSoftReset.Size = new System.Drawing.Size(83, 23);
            this.btn_SpeedRunSoftReset.TabIndex = 83;
            this.btn_SpeedRunSoftReset.Text = "Soft Reset";
            this.btn_SpeedRunSoftReset.UseVisualStyleBackColor = true;
            this.btn_SpeedRunSoftReset.Click += new System.EventHandler(this.btn_SpeedRunSoftReset_Click);
            // 
            // tb_SpeedRunSoftResetTo
            // 
            this.tb_SpeedRunSoftResetTo.Location = new System.Drawing.Point(183, 242);
            this.tb_SpeedRunSoftResetTo.Name = "tb_SpeedRunSoftResetTo";
            this.tb_SpeedRunSoftResetTo.Size = new System.Drawing.Size(21, 20);
            this.tb_SpeedRunSoftResetTo.TabIndex = 82;
            this.tb_SpeedRunSoftResetTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_SpeedRunSettings
            // 
            this.btn_SpeedRunSettings.AutoSize = true;
            this.btn_SpeedRunSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_SpeedRunSettings.Location = new System.Drawing.Point(3, 159);
            this.btn_SpeedRunSettings.Name = "btn_SpeedRunSettings";
            this.btn_SpeedRunSettings.Size = new System.Drawing.Size(45, 13);
            this.btn_SpeedRunSettings.TabIndex = 81;
            this.btn_SpeedRunSettings.Text = "Settings";
            // 
            // label_SpeedRunMainSM
            // 
            this.label_SpeedRunMainSM.AutoSize = true;
            this.label_SpeedRunMainSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_SpeedRunMainSM.Location = new System.Drawing.Point(3, 202);
            this.label_SpeedRunMainSM.Name = "label_SpeedRunMainSM";
            this.label_SpeedRunMainSM.Size = new System.Drawing.Size(102, 13);
            this.label_SpeedRunMainSM.TabIndex = 80;
            this.label_SpeedRunMainSM.Text = "Main State Machine";
            // 
            // checkB_SpeedRunTryOvertake
            // 
            this.checkB_SpeedRunTryOvertake.AutoSize = true;
            this.checkB_SpeedRunTryOvertake.Location = new System.Drawing.Point(6, 176);
            this.checkB_SpeedRunTryOvertake.Name = "checkB_SpeedRunTryOvertake";
            this.checkB_SpeedRunTryOvertake.Size = new System.Drawing.Size(98, 17);
            this.checkB_SpeedRunTryOvertake.TabIndex = 79;
            this.checkB_SpeedRunTryOvertake.Text = "Try to overtake";
            this.checkB_SpeedRunTryOvertake.UseVisualStyleBackColor = true;
            this.checkB_SpeedRunTryOvertake.CheckedChanged += new System.EventHandler(this.checkB_SpeedRunTryOvertake_CheckedChanged);
            // 
            // tb_SpeedRunParametersSetState
            // 
            this.tb_SpeedRunParametersSetState.Location = new System.Drawing.Point(99, 34);
            this.tb_SpeedRunParametersSetState.Name = "tb_SpeedRunParametersSetState";
            this.tb_SpeedRunParametersSetState.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersSetState.TabIndex = 54;
            this.tb_SpeedRunParametersSetState.Text = "0";
            this.tb_SpeedRunParametersSetState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkB_SpeedRunMainSMLap3
            // 
            this.checkB_SpeedRunMainSMLap3.AutoSize = true;
            this.checkB_SpeedRunMainSMLap3.Location = new System.Drawing.Point(6, 278);
            this.checkB_SpeedRunMainSMLap3.Name = "checkB_SpeedRunMainSMLap3";
            this.checkB_SpeedRunMainSMLap3.Size = new System.Drawing.Size(53, 17);
            this.checkB_SpeedRunMainSMLap3.TabIndex = 78;
            this.checkB_SpeedRunMainSMLap3.Text = "Lap 3";
            this.checkB_SpeedRunMainSMLap3.UseVisualStyleBackColor = true;
            // 
            // tb_SpeedRunParametersGetKd
            // 
            this.tb_SpeedRunParametersGetKd.Location = new System.Drawing.Point(155, 100);
            this.tb_SpeedRunParametersGetKd.Name = "tb_SpeedRunParametersGetKd";
            this.tb_SpeedRunParametersGetKd.ReadOnly = true;
            this.tb_SpeedRunParametersGetKd.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersGetKd.TabIndex = 62;
            this.tb_SpeedRunParametersGetKd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkB_SpeedRunMainSMLap2
            // 
            this.checkB_SpeedRunMainSMLap2.AutoSize = true;
            this.checkB_SpeedRunMainSMLap2.Location = new System.Drawing.Point(6, 263);
            this.checkB_SpeedRunMainSMLap2.Name = "checkB_SpeedRunMainSMLap2";
            this.checkB_SpeedRunMainSMLap2.Size = new System.Drawing.Size(53, 17);
            this.checkB_SpeedRunMainSMLap2.TabIndex = 77;
            this.checkB_SpeedRunMainSMLap2.Text = "Lap 2";
            this.checkB_SpeedRunMainSMLap2.UseVisualStyleBackColor = true;
            // 
            // tb_SpeedRunParametersSetKd
            // 
            this.tb_SpeedRunParametersSetKd.Location = new System.Drawing.Point(99, 100);
            this.tb_SpeedRunParametersSetKd.Name = "tb_SpeedRunParametersSetKd";
            this.tb_SpeedRunParametersSetKd.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersSetKd.TabIndex = 63;
            this.tb_SpeedRunParametersSetKd.Text = "3,5";
            this.tb_SpeedRunParametersSetKd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkB_SpeedRunMainSMLap1
            // 
            this.checkB_SpeedRunMainSMLap1.AutoSize = true;
            this.checkB_SpeedRunMainSMLap1.Location = new System.Drawing.Point(6, 248);
            this.checkB_SpeedRunMainSMLap1.Name = "checkB_SpeedRunMainSMLap1";
            this.checkB_SpeedRunMainSMLap1.Size = new System.Drawing.Size(53, 17);
            this.checkB_SpeedRunMainSMLap1.TabIndex = 76;
            this.checkB_SpeedRunMainSMLap1.Text = "Lap 1";
            this.checkB_SpeedRunMainSMLap1.UseVisualStyleBackColor = true;
            // 
            // tb_SpeedRunParametersSetP
            // 
            this.tb_SpeedRunParametersSetP.Location = new System.Drawing.Point(99, 56);
            this.tb_SpeedRunParametersSetP.Name = "tb_SpeedRunParametersSetP";
            this.tb_SpeedRunParametersSetP.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersSetP.TabIndex = 57;
            this.tb_SpeedRunParametersSetP.Text = "0,75";
            this.tb_SpeedRunParametersSetP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkB_SpeedRunMainSMOvertaking
            // 
            this.checkB_SpeedRunMainSMOvertaking.AutoSize = true;
            this.checkB_SpeedRunMainSMOvertaking.Location = new System.Drawing.Point(6, 233);
            this.checkB_SpeedRunMainSMOvertaking.Name = "checkB_SpeedRunMainSMOvertaking";
            this.checkB_SpeedRunMainSMOvertaking.Size = new System.Drawing.Size(78, 17);
            this.checkB_SpeedRunMainSMOvertaking.TabIndex = 75;
            this.checkB_SpeedRunMainSMOvertaking.Text = "Overtaking";
            this.checkB_SpeedRunMainSMOvertaking.UseVisualStyleBackColor = true;
            // 
            // tb_SpeedRunParametersActualKp
            // 
            this.tb_SpeedRunParametersActualKp.Location = new System.Drawing.Point(43, 78);
            this.tb_SpeedRunParametersActualKp.Name = "tb_SpeedRunParametersActualKp";
            this.tb_SpeedRunParametersActualKp.ReadOnly = true;
            this.tb_SpeedRunParametersActualKp.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersActualKp.TabIndex = 61;
            this.tb_SpeedRunParametersActualKp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkB_SpeedRunMainSMParadeLap
            // 
            this.checkB_SpeedRunMainSMParadeLap.AutoSize = true;
            this.checkB_SpeedRunMainSMParadeLap.Location = new System.Drawing.Point(6, 218);
            this.checkB_SpeedRunMainSMParadeLap.Name = "checkB_SpeedRunMainSMParadeLap";
            this.checkB_SpeedRunMainSMParadeLap.Size = new System.Drawing.Size(81, 17);
            this.checkB_SpeedRunMainSMParadeLap.TabIndex = 74;
            this.checkB_SpeedRunMainSMParadeLap.Text = "Parade Lap";
            this.checkB_SpeedRunMainSMParadeLap.UseVisualStyleBackColor = true;
            // 
            // tb_SpeedRunParametersGetState
            // 
            this.tb_SpeedRunParametersGetState.Location = new System.Drawing.Point(155, 34);
            this.tb_SpeedRunParametersGetState.Name = "tb_SpeedRunParametersGetState";
            this.tb_SpeedRunParametersGetState.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersGetState.TabIndex = 43;
            this.tb_SpeedRunParametersGetState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pic_SpeedRunMap
            // 
            this.pic_SpeedRunMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_SpeedRunMap.Image = global::OrientApp.Properties.Resources.SpeedRunMap_mini;
            this.pic_SpeedRunMap.Location = new System.Drawing.Point(215, 8);
            this.pic_SpeedRunMap.Name = "pic_SpeedRunMap";
            this.pic_SpeedRunMap.Size = new System.Drawing.Size(249, 284);
            this.pic_SpeedRunMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SpeedRunMap.TabIndex = 50;
            this.pic_SpeedRunMap.TabStop = false;
            // 
            // tb_SpeedRunParametersActualKd
            // 
            this.tb_SpeedRunParametersActualKd.Location = new System.Drawing.Point(43, 100);
            this.tb_SpeedRunParametersActualKd.Name = "tb_SpeedRunParametersActualKd";
            this.tb_SpeedRunParametersActualKd.ReadOnly = true;
            this.tb_SpeedRunParametersActualKd.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersActualKd.TabIndex = 64;
            this.tb_SpeedRunParametersActualKd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_SpeedRunParametersActualState
            // 
            this.tb_SpeedRunParametersActualState.Location = new System.Drawing.Point(43, 34);
            this.tb_SpeedRunParametersActualState.Name = "tb_SpeedRunParametersActualState";
            this.tb_SpeedRunParametersActualState.ReadOnly = true;
            this.tb_SpeedRunParametersActualState.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersActualState.TabIndex = 55;
            this.tb_SpeedRunParametersActualState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_SpeedRunParametersState
            // 
            this.label_SpeedRunParametersState.AutoSize = true;
            this.label_SpeedRunParametersState.Location = new System.Drawing.Point(6, 37);
            this.label_SpeedRunParametersState.Name = "label_SpeedRunParametersState";
            this.label_SpeedRunParametersState.Size = new System.Drawing.Size(32, 13);
            this.label_SpeedRunParametersState.TabIndex = 49;
            this.label_SpeedRunParametersState.Text = "State";
            // 
            // label_SpeedRunParametersKp
            // 
            this.label_SpeedRunParametersKp.AutoSize = true;
            this.label_SpeedRunParametersKp.Location = new System.Drawing.Point(11, 81);
            this.label_SpeedRunParametersKp.Name = "label_SpeedRunParametersKp";
            this.label_SpeedRunParametersKp.Size = new System.Drawing.Size(27, 13);
            this.label_SpeedRunParametersKp.TabIndex = 69;
            this.label_SpeedRunParametersKp.Text = "K_P";
            // 
            // tb_SpeedRunParametersSetKp
            // 
            this.tb_SpeedRunParametersSetKp.Location = new System.Drawing.Point(99, 78);
            this.tb_SpeedRunParametersSetKp.Name = "tb_SpeedRunParametersSetKp";
            this.tb_SpeedRunParametersSetKp.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersSetKp.TabIndex = 60;
            this.tb_SpeedRunParametersSetKp.Text = "0.02";
            this.tb_SpeedRunParametersSetKp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_SpeedRunParametersP
            // 
            this.label_SpeedRunParametersP.AutoSize = true;
            this.label_SpeedRunParametersP.Location = new System.Drawing.Point(24, 59);
            this.label_SpeedRunParametersP.Name = "label_SpeedRunParametersP";
            this.label_SpeedRunParametersP.Size = new System.Drawing.Size(14, 13);
            this.label_SpeedRunParametersP.TabIndex = 68;
            this.label_SpeedRunParametersP.Text = "P";
            // 
            // btn_SpeedRunGet
            // 
            this.btn_SpeedRunGet.Location = new System.Drawing.Point(155, 146);
            this.btn_SpeedRunGet.Name = "btn_SpeedRunGet";
            this.btn_SpeedRunGet.Size = new System.Drawing.Size(50, 23);
            this.btn_SpeedRunGet.TabIndex = 73;
            this.btn_SpeedRunGet.Text = "Get";
            this.btn_SpeedRunGet.UseVisualStyleBackColor = true;
            this.btn_SpeedRunGet.Click += new System.EventHandler(this.btn_SpeedRunGet_Click);
            // 
            // label_SpeedRunParametersKd
            // 
            this.label_SpeedRunParametersKd.AutoSize = true;
            this.label_SpeedRunParametersKd.Location = new System.Drawing.Point(10, 103);
            this.label_SpeedRunParametersKd.Name = "label_SpeedRunParametersKd";
            this.label_SpeedRunParametersKd.Size = new System.Drawing.Size(28, 13);
            this.label_SpeedRunParametersKd.TabIndex = 70;
            this.label_SpeedRunParametersKd.Text = "K_D";
            // 
            // tb_SpeedRunParametersGetSpeed
            // 
            this.tb_SpeedRunParametersGetSpeed.Location = new System.Drawing.Point(155, 123);
            this.tb_SpeedRunParametersGetSpeed.Name = "tb_SpeedRunParametersGetSpeed";
            this.tb_SpeedRunParametersGetSpeed.ReadOnly = true;
            this.tb_SpeedRunParametersGetSpeed.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersGetSpeed.TabIndex = 65;
            this.tb_SpeedRunParametersGetSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_SpeedRunParametersGetP
            // 
            this.tb_SpeedRunParametersGetP.Location = new System.Drawing.Point(155, 56);
            this.tb_SpeedRunParametersGetP.Name = "tb_SpeedRunParametersGetP";
            this.tb_SpeedRunParametersGetP.ReadOnly = true;
            this.tb_SpeedRunParametersGetP.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersGetP.TabIndex = 56;
            this.tb_SpeedRunParametersGetP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_SpeedRunParametersActual
            // 
            this.label_SpeedRunParametersActual.AutoSize = true;
            this.label_SpeedRunParametersActual.Location = new System.Drawing.Point(50, 18);
            this.label_SpeedRunParametersActual.Name = "label_SpeedRunParametersActual";
            this.label_SpeedRunParametersActual.Size = new System.Drawing.Size(37, 13);
            this.label_SpeedRunParametersActual.TabIndex = 51;
            this.label_SpeedRunParametersActual.Text = "Actual";
            // 
            // label_SpeedRunParametersGetValue
            // 
            this.label_SpeedRunParametersGetValue.AutoSize = true;
            this.label_SpeedRunParametersGetValue.Location = new System.Drawing.Point(152, 18);
            this.label_SpeedRunParametersGetValue.Name = "label_SpeedRunParametersGetValue";
            this.label_SpeedRunParametersGetValue.Size = new System.Drawing.Size(54, 13);
            this.label_SpeedRunParametersGetValue.TabIndex = 53;
            this.label_SpeedRunParametersGetValue.Text = "Get Value";
            // 
            // tb_SpeedRunParametersGetKp
            // 
            this.tb_SpeedRunParametersGetKp.Location = new System.Drawing.Point(155, 78);
            this.tb_SpeedRunParametersGetKp.Name = "tb_SpeedRunParametersGetKp";
            this.tb_SpeedRunParametersGetKp.ReadOnly = true;
            this.tb_SpeedRunParametersGetKp.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersGetKp.TabIndex = 59;
            this.tb_SpeedRunParametersGetKp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_SpeedRunParametersActualSpeed
            // 
            this.tb_SpeedRunParametersActualSpeed.Location = new System.Drawing.Point(44, 123);
            this.tb_SpeedRunParametersActualSpeed.Name = "tb_SpeedRunParametersActualSpeed";
            this.tb_SpeedRunParametersActualSpeed.ReadOnly = true;
            this.tb_SpeedRunParametersActualSpeed.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersActualSpeed.TabIndex = 67;
            this.tb_SpeedRunParametersActualSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_SpeedRunSet
            // 
            this.btn_SpeedRunSet.Location = new System.Drawing.Point(100, 146);
            this.btn_SpeedRunSet.Name = "btn_SpeedRunSet";
            this.btn_SpeedRunSet.Size = new System.Drawing.Size(50, 23);
            this.btn_SpeedRunSet.TabIndex = 72;
            this.btn_SpeedRunSet.Text = "Set";
            this.btn_SpeedRunSet.UseVisualStyleBackColor = true;
            this.btn_SpeedRunSet.Click += new System.EventHandler(this.btn_SpeedRunSet_Click);
            // 
            // label_SpeedRunParametersSpeed
            // 
            this.label_SpeedRunParametersSpeed.AutoSize = true;
            this.label_SpeedRunParametersSpeed.Location = new System.Drawing.Point(3, 126);
            this.label_SpeedRunParametersSpeed.Name = "label_SpeedRunParametersSpeed";
            this.label_SpeedRunParametersSpeed.Size = new System.Drawing.Size(38, 13);
            this.label_SpeedRunParametersSpeed.TabIndex = 71;
            this.label_SpeedRunParametersSpeed.Text = "Speed";
            // 
            // tb_SpeedRunParametersSetSpeed
            // 
            this.tb_SpeedRunParametersSetSpeed.Location = new System.Drawing.Point(99, 123);
            this.tb_SpeedRunParametersSetSpeed.Name = "tb_SpeedRunParametersSetSpeed";
            this.tb_SpeedRunParametersSetSpeed.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersSetSpeed.TabIndex = 66;
            this.tb_SpeedRunParametersSetSpeed.Text = "18";
            this.tb_SpeedRunParametersSetSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_SpeedRunParametersActualP
            // 
            this.tb_SpeedRunParametersActualP.Location = new System.Drawing.Point(43, 56);
            this.tb_SpeedRunParametersActualP.Name = "tb_SpeedRunParametersActualP";
            this.tb_SpeedRunParametersActualP.ReadOnly = true;
            this.tb_SpeedRunParametersActualP.Size = new System.Drawing.Size(50, 20);
            this.tb_SpeedRunParametersActualP.TabIndex = 58;
            this.tb_SpeedRunParametersActualP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_SpeedRunParametersSetValue
            // 
            this.label_SpeedRunParametersSetValue.AutoSize = true;
            this.label_SpeedRunParametersSetValue.Location = new System.Drawing.Point(97, 18);
            this.label_SpeedRunParametersSetValue.Name = "label_SpeedRunParametersSetValue";
            this.label_SpeedRunParametersSetValue.Size = new System.Drawing.Size(53, 13);
            this.label_SpeedRunParametersSetValue.TabIndex = 52;
            this.label_SpeedRunParametersSetValue.Text = "Set Value";
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
            this.tb_BoardLineSecondLinePos.TextChanged += new System.EventHandler(this.tb_BoardLineSecondLinePos_TextChanged);
            // 
            // tb_BoardLineMainLinePos
            // 
            this.tb_BoardLineMainLinePos.Location = new System.Drawing.Point(105, 39);
            this.tb_BoardLineMainLinePos.Name = "tb_BoardLineMainLinePos";
            this.tb_BoardLineMainLinePos.ReadOnly = true;
            this.tb_BoardLineMainLinePos.Size = new System.Drawing.Size(50, 20);
            this.tb_BoardLineMainLinePos.TabIndex = 33;
            this.tb_BoardLineMainLinePos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_BoardLineMainLinePos.TextChanged += new System.EventHandler(this.tb_BoardLineMainLinePos_TextChanged);
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
            // trackBar_BoardLineMainLinePos
            // 
            this.trackBar_BoardLineMainLinePos.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_BoardLineMainLinePos.Location = new System.Drawing.Point(14, 107);
            this.trackBar_BoardLineMainLinePos.Maximum = 130;
            this.trackBar_BoardLineMainLinePos.Minimum = -130;
            this.trackBar_BoardLineMainLinePos.Name = "trackBar_BoardLineMainLinePos";
            this.trackBar_BoardLineMainLinePos.Size = new System.Drawing.Size(163, 45);
            this.trackBar_BoardLineMainLinePos.TabIndex = 24;
            this.trackBar_BoardLineMainLinePos.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar_BoardLineSecondLinePos
            // 
            this.trackBar_BoardLineSecondLinePos.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_BoardLineSecondLinePos.Location = new System.Drawing.Point(14, 86);
            this.trackBar_BoardLineSecondLinePos.Maximum = 130;
            this.trackBar_BoardLineSecondLinePos.Minimum = -130;
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
            this.tb_SteeringWheelAngle.TextChanged += new System.EventHandler(this.tb_SteeringWheelAngle_TextChanged);
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
            this.tb_DistanceSensorRear.TextChanged += new System.EventHandler(this.tb_DistanceSensorRear_TextChanged);
            // 
            // tb_DistanceSensorRight
            // 
            this.tb_DistanceSensorRight.Location = new System.Drawing.Point(79, 136);
            this.tb_DistanceSensorRight.Name = "tb_DistanceSensorRight";
            this.tb_DistanceSensorRight.ReadOnly = true;
            this.tb_DistanceSensorRight.Size = new System.Drawing.Size(50, 20);
            this.tb_DistanceSensorRight.TabIndex = 22;
            this.tb_DistanceSensorRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_DistanceSensorRight.TextChanged += new System.EventHandler(this.tb_DistanceSensorRight_TextChanged);
            // 
            // tb_DistanceSensorFrontRight
            // 
            this.tb_DistanceSensorFrontRight.Location = new System.Drawing.Point(70, 71);
            this.tb_DistanceSensorFrontRight.Name = "tb_DistanceSensorFrontRight";
            this.tb_DistanceSensorFrontRight.ReadOnly = true;
            this.tb_DistanceSensorFrontRight.Size = new System.Drawing.Size(50, 20);
            this.tb_DistanceSensorFrontRight.TabIndex = 21;
            this.tb_DistanceSensorFrontRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_DistanceSensorFrontRight.TextChanged += new System.EventHandler(this.tb_DistanceSensorFrontRight_TextChanged);
            // 
            // tb_DistanceSensorFront
            // 
            this.tb_DistanceSensorFront.Location = new System.Drawing.Point(11, 48);
            this.tb_DistanceSensorFront.Name = "tb_DistanceSensorFront";
            this.tb_DistanceSensorFront.ReadOnly = true;
            this.tb_DistanceSensorFront.Size = new System.Drawing.Size(50, 20);
            this.tb_DistanceSensorFront.TabIndex = 20;
            this.tb_DistanceSensorFront.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_DistanceSensorFront.TextChanged += new System.EventHandler(this.tb_DistanceSensorFront_TextChanged);
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
            // gb_Scope
            // 
            this.gb_Scope.Location = new System.Drawing.Point(3, 0);
            this.gb_Scope.Name = "gb_Scope";
            this.gb_Scope.Size = new System.Drawing.Size(584, 224);
            this.gb_Scope.TabIndex = 10;
            this.gb_Scope.TabStop = false;
            this.gb_Scope.Text = "Scope";
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
            // gb_MazeRunParameters
            // 
            this.gb_MazeRunParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_MazeRunParameters.Controls.Add(this.label_MazeMainStateMachine);
            this.gb_MazeRunParameters.Controls.Add(this.checkB_MazeMainSMInclination);
            this.gb_MazeRunParameters.Controls.Add(this.checkB_MazeMainSMDiscovery);
            this.gb_MazeRunParameters.Controls.Add(this.label_MazeSegmentList);
            this.gb_MazeRunParameters.Controls.Add(this.checkListB_MazeSegmentList);
            this.gb_MazeRunParameters.Controls.Add(this.btn_MazeParametersGetParams);
            this.gb_MazeRunParameters.Controls.Add(this.label_MazeParametersGetValue);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersGetState);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersGetSpeed);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersGetKD);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersGetKP);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersSetState);
            this.gb_MazeRunParameters.Controls.Add(this.btn_MazeParametersSetStateTo);
            this.gb_MazeRunParameters.Controls.Add(this.label_MazeParametersResetStateTo);
            this.gb_MazeRunParameters.Controls.Add(this.tb_MazeParametersResetStateTo);
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
            // label_MazeMainStateMachine
            // 
            this.label_MazeMainStateMachine.AutoSize = true;
            this.label_MazeMainStateMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_MazeMainStateMachine.Location = new System.Drawing.Point(107, 165);
            this.label_MazeMainStateMachine.Name = "label_MazeMainStateMachine";
            this.label_MazeMainStateMachine.Size = new System.Drawing.Size(102, 13);
            this.label_MazeMainStateMachine.TabIndex = 92;
            this.label_MazeMainStateMachine.Text = "Main State Machine";
            // 
            // checkB_MazeMainSMInclination
            // 
            this.checkB_MazeMainSMInclination.AutoSize = true;
            this.checkB_MazeMainSMInclination.Location = new System.Drawing.Point(110, 196);
            this.checkB_MazeMainSMInclination.Name = "checkB_MazeMainSMInclination";
            this.checkB_MazeMainSMInclination.Size = new System.Drawing.Size(74, 17);
            this.checkB_MazeMainSMInclination.TabIndex = 88;
            this.checkB_MazeMainSMInclination.Text = "Inclination";
            this.checkB_MazeMainSMInclination.UseVisualStyleBackColor = true;
            // 
            // checkB_MazeMainSMDiscovery
            // 
            this.checkB_MazeMainSMDiscovery.AutoSize = true;
            this.checkB_MazeMainSMDiscovery.Location = new System.Drawing.Point(110, 181);
            this.checkB_MazeMainSMDiscovery.Name = "checkB_MazeMainSMDiscovery";
            this.checkB_MazeMainSMDiscovery.Size = new System.Drawing.Size(73, 17);
            this.checkB_MazeMainSMDiscovery.TabIndex = 87;
            this.checkB_MazeMainSMDiscovery.Text = "Discovery";
            this.checkB_MazeMainSMDiscovery.UseVisualStyleBackColor = true;
            // 
            // label_MazeSegmentList
            // 
            this.label_MazeSegmentList.AutoSize = true;
            this.label_MazeSegmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_MazeSegmentList.Location = new System.Drawing.Point(222, 16);
            this.label_MazeSegmentList.Name = "label_MazeSegmentList";
            this.label_MazeSegmentList.Size = new System.Drawing.Size(105, 16);
            this.label_MazeSegmentList.TabIndex = 86;
            this.label_MazeSegmentList.Text = "Maze Segments";
            // 
            // checkListB_MazeSegmentList
            // 
            this.checkListB_MazeSegmentList.FormattingEnabled = true;
            this.checkListB_MazeSegmentList.Items.AddRange(new object[] {
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
            this.checkListB_MazeSegmentList.Location = new System.Drawing.Point(239, 35);
            this.checkListB_MazeSegmentList.Name = "checkListB_MazeSegmentList";
            this.checkListB_MazeSegmentList.Size = new System.Drawing.Size(54, 184);
            this.checkListB_MazeSegmentList.TabIndex = 9;
            // 
            // btn_MazeParametersGetParams
            // 
            this.btn_MazeParametersGetParams.Location = new System.Drawing.Point(155, 129);
            this.btn_MazeParametersGetParams.Name = "btn_MazeParametersGetParams";
            this.btn_MazeParametersGetParams.Size = new System.Drawing.Size(54, 22);
            this.btn_MazeParametersGetParams.TabIndex = 76;
            this.btn_MazeParametersGetParams.Text = "Get";
            this.btn_MazeParametersGetParams.UseVisualStyleBackColor = true;
            this.btn_MazeParametersGetParams.Click += new System.EventHandler(this.btn_MazeParametersGetParams_Click);
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
            this.tb_MazeParametersSetState.Text = "0";
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
            this.btn_MazeParametersSetStateTo.Click += new System.EventHandler(this.btn_MazeParametersSetStateTo_Click);
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
            // tb_MazeParametersResetStateTo
            // 
            this.tb_MazeParametersResetStateTo.Location = new System.Drawing.Point(61, 165);
            this.tb_MazeParametersResetStateTo.Name = "tb_MazeParametersResetStateTo";
            this.tb_MazeParametersResetStateTo.Size = new System.Drawing.Size(23, 20);
            this.tb_MazeParametersResetStateTo.TabIndex = 67;
            this.tb_MazeParametersResetStateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.tb_MazeParametersSetSpeed.Text = "18";
            this.tb_MazeParametersSetSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_MazeParametersSetKD
            // 
            this.tb_MazeParametersSetKD.Location = new System.Drawing.Point(99, 80);
            this.tb_MazeParametersSetKD.Name = "tb_MazeParametersSetKD";
            this.tb_MazeParametersSetKD.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersSetKD.TabIndex = 62;
            this.tb_MazeParametersSetKD.Text = "3,5";
            this.tb_MazeParametersSetKD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_MazeParametersSetKP
            // 
            this.tb_MazeParametersSetKP.Location = new System.Drawing.Point(99, 58);
            this.tb_MazeParametersSetKP.Name = "tb_MazeParametersSetKP";
            this.tb_MazeParametersSetKP.Size = new System.Drawing.Size(50, 20);
            this.tb_MazeParametersSetKP.TabIndex = 61;
            this.tb_MazeParametersSetKP.Text = "0,02";
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
            this.btn_MazeParametersSendParams.Click += new System.EventHandler(this.btn_MazeParametersSendParams_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_SpeedRunMap)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pict_TeamLogo)).EndInit();
            this.gb_BoardLineInformations.ResumeLayout(false);
            this.gb_BoardLineInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BoardLineMainLinePos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BoardLineSecondLinePos)).EndInit();
            this.gb_BoardMotorInformations.ResumeLayout(false);
            this.gb_BoardMotorInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BoardMotorMainBatteryVoltage)).EndInit();
            this.gb_SteeringWheel.ResumeLayout(false);
            this.gb_SteeringWheel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SteeringWheel)).EndInit();
            this.bg_Encoder.ResumeLayout(false);
            this.bg_Encoder.PerformLayout();
            this.gb_DistanceSensors.ResumeLayout(false);
            this.gb_DistanceSensors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Car1)).EndInit();
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
        private System.Windows.Forms.Label label_SpeedRunParametersState;
        private System.Windows.Forms.Label label_SteeringWheelAngle;
        private System.Windows.Forms.TextBox tb_SteeringWheelAngle;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersGetState;
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
        private System.Windows.Forms.TextBox tb_MazeParametersResetStateTo;
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
        private System.Windows.Forms.PictureBox pic_SpeedRunMap;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersSetState;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersGetKd;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersSetKd;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersSetP;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersActualKp;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersActualKd;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersSetKp;
        private System.Windows.Forms.Button btn_SpeedRunGet;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersGetSpeed;
        private System.Windows.Forms.Label label_SpeedRunParametersActual;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersGetKp;
        private System.Windows.Forms.Button btn_SpeedRunSet;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersSetSpeed;
        private System.Windows.Forms.Label label_SpeedRunParametersSetValue;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersActualP;
        private System.Windows.Forms.Label label_SpeedRunParametersSpeed;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersActualSpeed;
        private System.Windows.Forms.Label label_SpeedRunParametersGetValue;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersGetP;
        private System.Windows.Forms.Label label_SpeedRunParametersKd;
        private System.Windows.Forms.Label label_SpeedRunParametersP;
        private System.Windows.Forms.TextBox tb_SpeedRunParametersActualState;
        private System.Windows.Forms.Label label_SpeedRunParametersKp;
        private System.Windows.Forms.CheckBox checkB_SpeedRunMainSMLap3;
        private System.Windows.Forms.CheckBox checkB_SpeedRunMainSMLap2;
        private System.Windows.Forms.CheckBox checkB_SpeedRunMainSMLap1;
        private System.Windows.Forms.CheckBox checkB_SpeedRunMainSMOvertaking;
        private System.Windows.Forms.CheckBox checkB_SpeedRunMainSMParadeLap;
        private System.Windows.Forms.Label btn_SpeedRunSettings;
        private System.Windows.Forms.Label label_SpeedRunMainSM;
        private System.Windows.Forms.CheckBox checkB_SpeedRunTryOvertake;
        private System.Windows.Forms.Label label_SpeedRunSoftResetTo;
        private System.Windows.Forms.Button btn_SpeedRunHardReset;
        private System.Windows.Forms.Button btn_SpeedRunSoftReset;
        private System.Windows.Forms.TextBox tb_SpeedRunSoftResetTo;
        private System.Windows.Forms.Label label_MazeMainStateMachine;
        private System.Windows.Forms.CheckBox checkB_MazeMainSMInclination;
        private System.Windows.Forms.CheckBox checkB_MazeMainSMDiscovery;
        private System.Windows.Forms.Label label_MazeSegmentList;
        private System.Windows.Forms.CheckedListBox checkListB_MazeSegmentList;
        private System.Windows.Forms.GroupBox gb_NaviMap;
        private System.Windows.Forms.GroupBox gb_Scope;
    }
}

