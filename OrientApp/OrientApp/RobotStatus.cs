using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientApp
{
    public class RobotStatus
    {
        // Singleton Objects.
        private static RobotStatus Instance;
        public Trace TraceInfo { get; set; }
        public ByteConverter Converter { get; set; }

        // Parameters.
        public double ServoAngle { get; set; }
        public Vector3D InertAccel { get; set; }
        public Vector3D InertAngularVelocity { get; set; }
        public double EncoderVelocity { get; set; }
        public NaviState NaviState { get; set; }
        public int DistSharp1 { get; set; }
        public int DistTof1 { get; set; }
        public int DistTof2 { get; set; }
        public int DistTof3 { get; set; }
        public bool CollWarnSharp1 { get; set; } // TODO calculated or received?
        public double MotorMainBatVolt { get; set; }
        public double MotorSecBatVolt { get; set; }
        public double MotorCurrent { get; set; }
        public int MotorSysCurrent { get; set; }
        public int MotorServoCurrent { get; set; }
        public int LineNumberOfLines { get; set; }
        public int LinePostionOfLine1 { get; set; }
        public int LinePostionOfLine2 { get; set; }

        /// <summary>
        /// Instanciate the singleton class and init the properties.
        /// </summary>
        /// <returns> RobotStatus object to store the informations about the car. </returns>
        public static RobotStatus GetInstance()
        {
            if (Instance == null)
            {
                Instance = new RobotStatus();
                Instance.Init();
            }

            return Instance;
        }

        private void Init ()
        {
            InertAccel = new Vector3D();
            InertAngularVelocity = new Vector3D();
            NaviState = new NaviState();

            TraceInfo = Trace.GetInstance();
            Converter = ByteConverter.GetInstance();
        }

        public void ProcessBytes (byte[] bytes)
        {
            foreach (var msg in TraceInfo.MsgOrder)
            {
                if (msg.Type == TraceData.E_MsgType.eFloat)
                {
                    switch (msg.Name)
                    {
                        case TraceData.E_MsgName.eServoAngle:
                            ServoAngle = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eSteeringWheelAngle:
                            ServoAngle = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);    // TODO
                            break;
                        case TraceData.E_MsgName.eInertAccelerationX:
                            InertAccel.X = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eInertAccelerationY:
                            InertAccel.Y = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eInertAccelerationZ:
                            InertAccel.Z = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eInertAngularVelocityX:
                            InertAngularVelocity.X = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eInertAngularVelocityY:
                            InertAngularVelocity.Y = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eInertAngularVelocityZ:
                            InertAngularVelocity.Z = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eEncoderVelocity:
                            EncoderVelocity = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eNaviN:
                            NaviState.Poistion.Y = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eNaviE:
                            NaviState.Poistion.X = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eNaviPsi:
                            NaviState.Orientation = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eMotorMainBatVolt:
                            MotorMainBatVolt = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eMotorSecBatVolt:
                            MotorSecBatVolt = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eMotorCurrent:
                            MotorCurrent = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (msg.Name)
                    {
                        case TraceData.E_MsgName.eDistSharp1:
                            DistSharp1 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eDistTof1:
                            DistTof1 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eDistTof2:
                            DistTof2 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eDistTof3:
                            DistTof3 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eMotorSysCurrent:
                            MotorSysCurrent = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eMotorServoCurrent:
                            MotorServoCurrent = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eLineNumOfLine:
                            LineNumberOfLines = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eLinePositionOfLine1:
                            LinePostionOfLine1 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eLinePositionOfLine2:
                            LinePostionOfLine2 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eCollWarnSharp1:
                            int warn = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            if (warn != 0)
                            {
                                CollWarnSharp1 = true;
                            }
                            else
                            {
                                CollWarnSharp1 = false;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
