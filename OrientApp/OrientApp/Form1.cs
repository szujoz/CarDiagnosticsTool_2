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

        public Form1()
        {
            MsgList = new List<byte[]>(1);
            
            InitializeComponent();

            TraceInfo = Trace.GetInstance();
            Converter = ByteConverter.GetInstance();
            CarStatus = RobotStatus.GetInstance();            
            
            // DEBUG
            // DistSharp = 277cm, InertAccX = 1.52
            string str = "AA11100277010471015200000000000000000000000000000000000999999999900000999990000000000000000000000000000000000";
            byte[] data = Encoding.ASCII.GetBytes(str);

            ThreadPool.QueueUserWorkItem(StoreAndDisplayCarData, new object[] { data });

            CarStatus.ProcessBytes(data);
            tb_InertialAccelerationX.Text = CarStatus.InertAccel.X.ToString();
            tb_DistanceSensorRear.Text = CarStatus.DistSharp1.ToString();

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

        public void DisplayReceivedSerialBytes (Object obj)
        {
            // Convert param to bytes.
            object[] array = obj as object[];
            byte[] bytes = Encoding.ASCII.GetBytes(array[0].ToString());

            // Common resource, must be protected.
            lock (MsgList)
            {
                MsgList.Add(bytes);

                if (MsgList.Count == MsgList.Capacity)
                {
                    Invoke(new FormWriterDelegate(WriteRichTextBox));
                }
            }
        }

        public void StoreAndDisplayCarData (Object obj)
        {
            // Convert param to bytes.
            object[] array = obj as object[];
            byte[] bytes = Encoding.ASCII.GetBytes(array[0].ToString());

            lock (CarStatus)
            {
                CarStatus.ProcessBytes(bytes);

                if (InvokeRequired)
                {
                    Invoke(new FormWriterDelegate(UpdateUI));
                }
            }

        }

        public delegate void FormWriterDelegate ();

        public void WriteRichTextBox ()
        {
            if (cntr == 10)
            {
                cntr = 0;
                rtb_SerialData.Text = "";
            }                

            foreach (var elem in MsgList)
            {
                rtb_SerialData.Text += Encoding.Default.GetString(elem);
                rtb_SerialData.Text += "\r\n";
            }

            MsgList.Clear();
            cntr++;
        }

        public void UpdateUI ()
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
            tb_SteeringWheelAngle.Text = CarStatus.ServoAngle.ToString(); // TODO servo and wheel separate.

            // Motor Board Info group box.
            tb_BoardMotorMainBatteryVoltage.Text = CarStatus.MotorMainBatVolt.ToString();
            tb_BoardMotorSecondaryBatteryVoltage.Text = CarStatus.MotorSecBatVolt.ToString();
            tb_BoardMotorMotorCurrent.Text = CarStatus.MotorCurrent.ToString();
            tb_BoardMotorSystemCurrent.Text = CarStatus.MotorSysCurrent.ToString();
            tb_BoardMotorServoCurrent.Text = CarStatus.MotorServoCurrent.ToString();
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
    }
}
