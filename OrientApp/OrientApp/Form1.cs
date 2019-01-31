using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace OrientApp
{
    public partial class Form1 : Form
    {
        public int cntr { get; set; }
        public List<byte[]> MsgList { get; set; }
        public Trace TraceInfo { get; set; }
        public ByteConverter Converter { get; set; }
        public RobotStatus CarStatus { get; set; }
        public ControlCmd Commands { get; set; }

        private int collisionThreshold = 30;    // cm

        public Form1()
        {
            MsgList = new List<byte[]>(1);
            
            InitializeComponent();

            TraceInfo = Trace.GetInstance();
            Converter = ByteConverter.GetInstance();
            CarStatus = RobotStatus.GetInstance();
            Commands  = ControlCmd.GetInstance();

            // DEBUG
            //DistSharp = 277cm, InertAccX = 1.52
            //string str1 = "AA209-1050-5023314150227100220010050525512345678912345678912345678912345678912345678912345678912345678912345678912345678912345618912345678991101011000015678912345678910145678912345678912345678912345678912345r";
            //ThreadPool.QueueUserWorkItem(StoreAndDisplayCarData, new object[] { str1 });

            //bool b1 = true;
            //bool b2 = false;

            //int i1 = 7;
            //int i2 = 42;
            //int i3 = 666;
            //int i4 = 91823;
            //int i5 = -2;
            //int i6 = -10;
            //int i7 = -202;

            //double d1 = 1.2;
            //double d2 = 0.67;
            //double d3 = 45.1;
            //double d4 = 102.1;
            //double d5 = 9.234;
            //double d8 = 444.555;
            //double d6 = -0.2;
            //double d7 = -0.12;
            //double db8 = -10.2;
            //double d9 = -55.89;
            //double d10 = 1;
            //double d11 = -5;

            //var v1 = Converter.ConvertBoolToByte(b1);
            //var v2 = Converter.ConvertBoolToByte(b2);

            //var v01 = Converter.ConvertIntToBytes(i1, 3);
            //var v02 = Converter.ConvertIntToBytes(i2, 3);
            //var v03 = Converter.ConvertIntToBytes(i3, 3);
            //var v04 = Converter.ConvertIntToBytes(i4, 3);
            //var v05 = Converter.ConvertIntToBytes(i5, 3);
            //var v06 = Converter.ConvertIntToBytes(i6, 3);
            //var v07 = Converter.ConvertIntToBytes(i7, 3);

            //var vd1 = Converter.ConvertFloatToBytes(d1, 3, 1);
            //var vd2 = Converter.ConvertFloatToBytes(d2, 3, 1);
            //var vd3 = Converter.ConvertFloatToBytes(d3, 3, 1);
            //var vd4 = Converter.ConvertFloatToBytes(d4, 3, 1);
            //var vd5 = Converter.ConvertFloatToBytes(d5, 3, 1);
            //var vd6 = Converter.ConvertFloatToBytes(d6, 3, 1);
            //var vd7 = Converter.ConvertFloatToBytes(d7, 3, 1);
            //var vd8 = Converter.ConvertFloatToBytes(db8, 3, 1);
            //var vd9 = Converter.ConvertFloatToBytes(d9, 3, 1);
            //var vd10 = Converter.ConvertFloatToBytes(d10, 3, 1);
            //var vd11 = Converter.ConvertFloatToBytes(d11, 3, 1);
           
            //string str2 = "AA11100277010471015205500084561205502200004457888800000999999999900000999990000000000000000000000000000000000";
            //ThreadPool.QueueUserWorkItem(StoreAndDisplayCarData, new object[] { str2 });

            //tb_InertialAccelerationX.Text = CarStatus.InertAccel.X.ToString();
            //tb_DistanceSensorRear.Text = CarStatus.DistSharp1.ToString();

            // END DEBUG

            string[] ports = SerialPort.GetPortNames();
            foreach(var elem in ports)
            {
                cb_SerialComPort.Items.Add(elem);
            }
            cb_SerialComPort.SelectedIndex = 1;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialPort.ReadLine();

            // Write received werial data into a richtextbox, so the user can see a log.
            ThreadPool.QueueUserWorkItem(DisplayReceivedSerialBytes, new object[] { line });

            // Process and store the received car infos, then display them in their textbox.
            ThreadPool.QueueUserWorkItem(StoreAndDisplayCarData,     new object[] { line });
        }

        private void DisplayReceivedSerialBytes (Object obj)
        {
            // Common resource, must be protected.
            lock (MsgList)
            {
                // Convert param to bytes.
                object[] array = obj as object[];
                string str = array[0].ToString();
                byte[] bytes = Encoding.ASCII.GetBytes(str);

                MsgList.Add(bytes);

                if (MsgList.Count == MsgList.Capacity)
                {
                    Invoke(new FormWriterDelegate(WriteRichTextBox));
                }
            }
        }

        private void StoreAndDisplayCarData (Object obj)
        {
            lock (CarStatus)
            {
                object[] array = obj as object[];
                string str = array[0].ToString();
                byte[] bytes = Encoding.ASCII.GetBytes(str);

                if (CheckMessageLenght(bytes))
                {
                    CarStatus.ProcessBytes(bytes);

                    if (InvokeRequired)
                    {
                        Invoke(new FormWriterDelegate(UpdateUI));
                    }
                    else
                    {
                        UpdateUI();
                    }
                }
            }
        }

        private bool CheckMessageLenght (byte[] msg)
        {
            bool fullMessage = false;
            int messageLen = 0;

            if (msg[0] == 'A' && msg[1] == 'A')
            {
                // Read out the lenght (-1 because of the \r\n).
                messageLen = (msg[2] - '0') * 100 + (msg[3] - '0') * 10 + (msg[4] - '0') - 1;

                if (msg.Length == messageLen)
                {
                    fullMessage = true;
                }
            }

            return fullMessage;
        }

        private delegate void FormWriterDelegate ();

        private void WriteRichTextBox ()
        {
            if (cntr == 100)
            {
                cntr = 0;
                rtb_SerialData.Text = "";
            }                

            foreach (var elem in MsgList)
            {
                rtb_SerialData.Text = Encoding.ASCII.GetString(elem) + rtb_SerialData.Text;
                rtb_SerialData.Text += "\r\n";
            }

            MsgList.Clear();
            cntr++;
        }

        /// <summary>
        /// This method reads out the data from the CarStatus object and displays them on the UI in the appropriate textbox.
        /// </summary>
        private void UpdateUI ()
        {
            // Navigation Data group box.
            tb_NaviPoistionNorth.Text = CarStatus.NaviState.Poistion.Y.ToString();
            tb_NaviPoistionEast.Text = CarStatus.NaviState.Poistion.X.ToString();
            tb_NaviOrientation.Text = CarStatus.NaviState.Orientation.ToString();

            // Encoder group box.
            tb_EncoderVelocity.Text = CarStatus.EncoderVelocity.ToString();

            // Distance Sensors group box.
            tb_DistanceSensorFront.Text = CarStatus.DistTof1.ToString();
            tb_DistanceSensorFrontRight.Text = CarStatus.DistTof2.ToString();
            tb_DistanceSensorRight.Text = CarStatus.DistTof3.ToString();
            tb_DistanceSensorRear.Text = CarStatus.DistSharp1.ToString();

            // Inertial Sensor group box.
            tb_InertialAccelerationX.Text = CarStatus.InertAccel.X.ToString();
            tb_InertialAccelerationY.Text = CarStatus.InertAccel.Y.ToString();
            tb_InertialAccelerationZ.Text = CarStatus.InertAccel.Z.ToString();
            tb_InertialAngularVelocityPhi.Text = CarStatus.InertAngularVelocity.X.ToString();
            tb_InertialAngularVelocityTheta.Text = CarStatus.InertAngularVelocity.Y.ToString();
            tb_InertialAngularVelocityPsi.Text = CarStatus.InertAngularVelocity.Z.ToString();

            // Steering Wheel group box.
            tb_SteeringWheelAngle.Text = CarStatus.SteeringWheelAngle.ToString();
            // TODO Servo angle display?

            // Motor Board Info group box.
            tb_BoardMotorMainBatteryVoltage.Text = CarStatus.MotorMainBatVolt.ToString();
            tb_BoardMotorSecondaryBatteryVoltage.Text = CarStatus.MotorSecBatVolt.ToString();
            tb_BoardMotorMotorCurrent.Text = CarStatus.MotorCurrent.ToString();
            tb_BoardMotorSystemCurrent.Text = CarStatus.MotorSysCurrent.ToString();
            tb_BoardMotorServoCurrent.Text = CarStatus.MotorServoCurrent.ToString();

            // Line Sensor Data group box.
            tb_BoardLineLineNumber.Text = CarStatus.LineMainLinePos.ToString();
            tb_BoardLineMainLinePos.Text = CarStatus.LineMainLinePos.ToString();
            tb_BoardLineSecondLinePos.Text = CarStatus.LineSecLinePos.ToString();

            // Maze Parameters group box.
            tb_MazeParametersActualState.Text = CarStatus.MazeActState.ToString();
            tb_MazeParametersActualKP.Text = CarStatus.MazeActKp.ToString();
            tb_MazeParametersActualKD.Text = CarStatus.MazeActKd.ToString();
            tb_MazeParametersActualSpeed.Text = CarStatus.MazeActSpeed.ToString();
            tb_MazeParametersGetKP.Text = CarStatus.MazeGetKp.ToString();
            tb_MazeParametersGetKD.Text = CarStatus.MazeGetKd.ToString();
            tb_MazeParametersGetSpeed.Text = CarStatus.MazeGetSpeed.ToString();
            MazeSegmentsCheckManager(CarStatus.MazeSegments);
            MazeMainSMManager(CarStatus.MazeMainSM);

            // Speed Run Parameters group box.
            tb_SpeedRunParametersActualState.Text = CarStatus.SRunActState.ToString();
            tb_SpeedRunParametersActualP.Text = CarStatus.SRunActP.ToString();
            tb_SpeedRunParametersActualKp.Text = CarStatus.SRunActKd.ToString();
            tb_SpeedRunParametersActualKd.Text = CarStatus.SRunActKd.ToString();
            tb_SpeedRunParametersActualSpeed.Text = CarStatus.SRunActSpeed.ToString();
            tb_SpeedRunParametersGetP.Text = CarStatus.SRunGetP.ToString();
            tb_SpeedRunParametersGetKp.Text = CarStatus.SRunGetKp.ToString();
            tb_SpeedRunParametersGetKd.Text = CarStatus.SRunGetKd.ToString();
            tb_SpeedRunParametersGetSpeed.Text = CarStatus.SRunGetSpeed.ToString();
            SpeedRunMainSMManager(CarStatus.SRunMainSM);
        }

        private void MazeSegmentsCheckManager (Int64 flags)
        {
            int flagNbr = 12;
            bool[] flagBits = new bool[flagNbr];

            for (int i = 0; i < flagNbr; i++)
            {
                if (flags % 10 == 1)
                {
                    flagBits[i] = true;
                }
                else
                {
                    flagBits[i] = false;
                }

                flags /= 10;
            }

            if (flagBits[0] == true) checkListB_MazeSegmentList.SetItemChecked(0,  true);
            else checkListB_MazeSegmentList.SetItemChecked(0, false);
            if (flagBits[1] == true) checkListB_MazeSegmentList.SetItemChecked(1, true);
            else checkListB_MazeSegmentList.SetItemChecked(1, false);
            if (flagBits[2] == true) checkListB_MazeSegmentList.SetItemChecked(2, true);
            else checkListB_MazeSegmentList.SetItemChecked(2, false);
            if (flagBits[3] == true) checkListB_MazeSegmentList.SetItemChecked(3, true);
            else checkListB_MazeSegmentList.SetItemChecked(3, false);
            if (flagBits[4] == true) checkListB_MazeSegmentList.SetItemChecked(4, true);
            else checkListB_MazeSegmentList.SetItemChecked(4, false);
            if (flagBits[5] == true) checkListB_MazeSegmentList.SetItemChecked(5, true);
            else checkListB_MazeSegmentList.SetItemChecked(5, false);
            if (flagBits[6] == true) checkListB_MazeSegmentList.SetItemChecked(6, true);
            else checkListB_MazeSegmentList.SetItemChecked(6, false);
            if (flagBits[7] == true) checkListB_MazeSegmentList.SetItemChecked(7, true);
            else checkListB_MazeSegmentList.SetItemChecked(7, false);
            if (flagBits[8] == true) checkListB_MazeSegmentList.SetItemChecked(8, true);
            else checkListB_MazeSegmentList.SetItemChecked(8, false);
            if (flagBits[9] == true) checkListB_MazeSegmentList.SetItemChecked(9, true);
            else checkListB_MazeSegmentList.SetItemChecked(9, false);
            if (flagBits[10] == true) checkListB_MazeSegmentList.SetItemChecked(10, true);
            else checkListB_MazeSegmentList.SetItemChecked(10, false);
            if (flagBits[11] == true) checkListB_MazeSegmentList.SetItemChecked(11, true);
            else checkListB_MazeSegmentList.SetItemChecked(11, false);
        }

        private void MazeMainSMManager (int sm)
        {
            checkB_MazeMainSMDiscovery.Checked = false;
            checkB_MazeMainSMInclination.Checked = false;

            if (CarStatus.MazeMainSM == 1)
            {
                checkB_MazeMainSMDiscovery.Checked = true;
                checkB_MazeMainSMInclination.Checked = false;
            }

            if (CarStatus.MazeMainSM == 2)
            {
                checkB_MazeMainSMDiscovery.Checked = false;
                checkB_MazeMainSMInclination.Checked = true;
            }
        }

        private void SpeedRunMainSMManager (int sm)
        {
            checkB_SpeedRunMainSMParadeLap.Checked = false;
            checkB_SpeedRunMainSMOvertaking.Checked = false;
            checkB_SpeedRunMainSMLap1.Checked = false;
            checkB_SpeedRunMainSMLap2.Checked = false;
            checkB_SpeedRunMainSMLap3.Checked = false;

            if (CarStatus.SRunMainSM == 1)
            {
                checkB_SpeedRunMainSMParadeLap.Checked = true;
                checkB_SpeedRunMainSMOvertaking.Checked = false;
                checkB_SpeedRunMainSMLap1.Checked = false;
                checkB_SpeedRunMainSMLap2.Checked = false;
                checkB_SpeedRunMainSMLap3.Checked = false;
            }

            if (CarStatus.SRunMainSM == 2)
            {
                checkB_SpeedRunMainSMParadeLap.Checked = false;
                checkB_SpeedRunMainSMOvertaking.Checked = true;
                checkB_SpeedRunMainSMLap1.Checked = false;
                checkB_SpeedRunMainSMLap2.Checked = false;
                checkB_SpeedRunMainSMLap3.Checked = false;
            }

            if (CarStatus.SRunMainSM == 3)
            {
                checkB_SpeedRunMainSMParadeLap.Checked = false;
                checkB_SpeedRunMainSMOvertaking.Checked = false;
                checkB_SpeedRunMainSMLap1.Checked = true;
                checkB_SpeedRunMainSMLap2.Checked = false;
                checkB_SpeedRunMainSMLap3.Checked = false;
            }

            if (CarStatus.SRunMainSM == 4)
            {
                checkB_SpeedRunMainSMParadeLap.Checked = false;
                checkB_SpeedRunMainSMOvertaking.Checked = false;
                checkB_SpeedRunMainSMLap1.Checked = false;
                checkB_SpeedRunMainSMLap2.Checked = true;
                checkB_SpeedRunMainSMLap3.Checked = false;
            }

            if (CarStatus.SRunMainSM == 5)
            {
                checkB_SpeedRunMainSMParadeLap.Checked = false;
                checkB_SpeedRunMainSMOvertaking.Checked = false;
                checkB_SpeedRunMainSMLap1.Checked = false;
                checkB_SpeedRunMainSMLap2.Checked = false;
                checkB_SpeedRunMainSMLap3.Checked = true;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            tb_SerialStatusInfo.Text = "Closed";
            tb_SerialStatusInfo.ForeColor = Color.Red;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = cb_SerialComPort.Text;
                serialPort.BaudRate = Convert.ToInt32(tb_SerialBaude.Text);
                serialPort.Open();
                tb_SerialStatusInfo.Text = "Open";
                tb_SerialStatusInfo.ForeColor = Color.Green;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tb_BoardMotorMainBatteryVoltage_TextChanged(object sender, EventArgs e)
        {
            AdjustMainBatteryTrackBar();
        }

        private void trackBar_BoardMotorMainBatteryVoltage_Scroll(object sender, EventArgs e)
        {
            AdjustMainBatteryTrackBar();
        }

        private void AdjustMainBatteryTrackBar ()
        {
            double maxVoltage = 12;
            double load = Convert.ToDouble(tb_BoardMotorMainBatteryVoltage.Text) / maxVoltage * 100;

            if (load > 100)
            {
                load = 100;
            }
            else if (load < 0)
            {
                load = 0;
            }

            trackBar_BoardMotorMainBatteryVoltage.Value = Convert.ToInt32(load);
        }

        private void tb_SerialStatusInfo_TextChanged(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                tb_SerialStatusInfo.Text = "Open";
                tb_SerialStatusInfo.ForeColor = Color.Green;
            }
            else
            {
                tb_SerialStatusInfo.Text = "Closed";
                tb_SerialStatusInfo.ForeColor = Color.Red;
            }
        }

        private void pict_TeamLogo_Click(object sender, EventArgs e)
        {
            Commands.StopCar = true;

            // Trigger 2x just to be sure.
            ThreadPool.QueueUserWorkItem(SendMessageToCar);
            ThreadPool.QueueUserWorkItem(SendMessageToCar);
        }

        private void SendMessageToCar (Object obj)
        {
            lock (Commands)
            {
                byte[] bytes = Commands.GetTxMessageBytes();

                if (serialPort.IsOpen)
                {
                    serialPort.Write(Encoding.ASCII.GetString(bytes));
                }

                // Reset one shot flags.
                Commands.StopCar = false;
                Commands.MazeMainSMReset = false;
                Commands.SRunHardReset = false;
                Commands.SRunSoftReset = false;
            }
        }

        private void tb_BoardLineMainLinePos_TextChanged(object sender, EventArgs e)
        {
            int max = 130;
            int min = -130;
            double pos = Convert.ToDouble(tb_BoardLineMainLinePos.Text);

            if (pos > max)
            {
                pos = max;
            }
            else if (pos < min)
            {
                pos = min;
            }

            trackBar_BoardLineMainLinePos.Value = Convert.ToInt32(pos);
        }

        private void tb_BoardLineSecondLinePos_TextChanged(object sender, EventArgs e)
        {
            int max = 130;
            int min = -130;
            double pos = Convert.ToDouble(tb_BoardLineSecondLinePos.Text);

            if (pos > max)
            {
                pos = max;
            }
            else if (pos < min)
            {
                pos = min;
            }

            trackBar_BoardLineSecondLinePos.Value = Convert.ToInt32(pos);
        }

        private void tb_DistanceSensorRear_TextChanged(object sender, EventArgs e)
        {
            int dist = Convert.ToInt16(tb_DistanceSensorRear.Text);

            if (dist <= collisionThreshold)
            {
                btn_DistanceCollisionWarningRear.BackColor = Color.Red;
            }
            else
            {
                btn_DistanceCollisionWarningRear.BackColor = Color.LightGray;
            }            
        }

        private void tb_DistanceSensorRight_TextChanged(object sender, EventArgs e)
        {
            int dist = Convert.ToInt16(tb_DistanceSensorRight.Text);

            if (dist <= collisionThreshold)
            {
                btn_DistanceCollisionWarningRight.BackColor = Color.Red;
            }
            else
            {
                btn_DistanceCollisionWarningRight.BackColor = Color.LightGray;
            }
        }

        private void tb_DistanceSensorFrontRight_TextChanged(object sender, EventArgs e)
        {
            int dist = Convert.ToInt16(tb_DistanceSensorFrontRight.Text);

            if (dist <= collisionThreshold)
            {
                btn_DistanceCollisionWarningFrontRight.BackColor = Color.Red;
            }
            else
            {
                btn_DistanceCollisionWarningFrontRight.BackColor = Color.LightGray;
            }
        }

        private void tb_DistanceSensorFront_TextChanged(object sender, EventArgs e)
        {
            int dist = Convert.ToInt16(tb_DistanceSensorFront.Text);

            if (dist <= collisionThreshold)
            {
                btn_DistanceCollisionWarningFront.BackColor = Color.Red;
            }
            else
            {
                btn_DistanceCollisionWarningFront.BackColor = Color.LightGray;
            }
        }

        private void btn_MazeParametersSendParams_Click(object sender, EventArgs e)
        {
            Commands.MazeSetState = Convert.ToInt32(tb_MazeParametersSetState.Text);
            Commands.MazeSetKp = Convert.ToDouble(tb_MazeParametersSetKP.Text.Replace('.', ','));
            Commands.MazeSetKd = Convert.ToDouble(tb_MazeParametersSetKD.Text.Replace('.', ','));
            Commands.MazeSetSpeed = Convert.ToInt32(tb_MazeParametersSetSpeed.Text);

            // Trigger sending.
            ThreadPool.QueueUserWorkItem(SendMessageToCar);
        }

        private void btn_MazeParametersGetParams_Click(object sender, EventArgs e)
        {
            Commands.MazeGetState = Convert.ToInt32(tb_MazeParametersGetState.Text);

            // Trigger sending.
            ThreadPool.QueueUserWorkItem(SendMessageToCar);
        }

        private void btn_MazeParametersSetStateTo_Click(object sender, EventArgs e)
        {
            Commands.MazeMainSMReset = true;
            Commands.MazeMainSMResetTo = Convert.ToInt32(tb_MazeParametersResetStateTo.Text);

            // Trigger sending.
            ThreadPool.QueueUserWorkItem(SendMessageToCar);
        }

        private void btn_SpeedRunSet_Click(object sender, EventArgs e)
        {
            Commands.SRunSetState = Convert.ToInt32(tb_SpeedRunParametersSetState.Text);
            Commands.SRunSetP = Convert.ToDouble(tb_SpeedRunParametersSetP.Text.Replace('.', ','));
            Commands.SRunSetKp = Convert.ToDouble(tb_SpeedRunParametersSetKp.Text.Replace('.', ','));
            Commands.SRunSetKd = Convert.ToDouble(tb_SpeedRunParametersSetKd.Text.Replace('.', ','));
            Commands.SRunSetSpeed = Convert.ToInt32(tb_SpeedRunParametersSetSpeed.Text);

            // Trigger sending.
            ThreadPool.QueueUserWorkItem(SendMessageToCar);
        }

        private void btn_SpeedRunGet_Click(object sender, EventArgs e)
        {
            Commands.SRunGetState = Convert.ToInt32(tb_SpeedRunParametersGetState.Text);

            // Trigger sending.
            ThreadPool.QueueUserWorkItem(SendMessageToCar);
        }

        private void btn_SpeedRunHardReset_Click(object sender, EventArgs e)
        {
            Commands.SRunHardReset = true;

            // Trigger sending.
            ThreadPool.QueueUserWorkItem(SendMessageToCar);
        }

        private void btn_SpeedRunSoftReset_Click(object sender, EventArgs e)
        {
            Commands.SRunSoftReset = true;
            Commands.SRunSoftResetTo = Convert.ToInt32(tb_SpeedRunSoftResetTo.Text);

            // Trigger sending.
            ThreadPool.QueueUserWorkItem(SendMessageToCar);
        }

        private void checkB_SpeedRunTryOvertake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB_SpeedRunTryOvertake.Checked == false)
            {
                Commands.SRunTryOvertake = false;
            }
            else
            {
                Commands.SRunTryOvertake = true;
            }

            // Trigger sending.
            ThreadPool.QueueUserWorkItem(SendMessageToCar);
        }

        private void tb_SteeringWheelAngle_TextChanged(object sender, EventArgs e)
        {
            var angle = Convert.ToDouble(tb_SteeringWheelAngle.Text);
            var pic = new Bitmap(OrientApp.Properties.Resources.automotive_steering_wheel2_512);

            pic_SteeringWheel.Image = pic;

            if (angle  >= 10*Math.PI/180)
            {
                pic.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else if (angle <= -10*Math.PI/180)
            {
                pic.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            

            /*using (Graphics gfx = Graphics.FromImage(pic))
            {
                gfx.Clear(Color.White);
                gfx.DrawImage(pic, new Point(100, 100));

                gfx.RotateTransform(30);
            }*/
        }
    }
}
