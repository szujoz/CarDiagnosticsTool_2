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
                            break;
                        case TraceData.E_MsgName.eSteeringWheelAngle:
                            break;
                        case TraceData.E_MsgName.eInertAccelerationX:
                            InertAccel.X = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eInertAccelerationY:
                            break;
                        case TraceData.E_MsgName.eInertAccelerationZ:
                            break;
                        case TraceData.E_MsgName.eInertAngularVelocityX:
                            break;
                        case TraceData.E_MsgName.eInertAngularVelocityY:
                            break;
                        case TraceData.E_MsgName.eInertAngularVelocityZ:
                            break;
                        case TraceData.E_MsgName.eEncoderVelocity:
                            break;
                        case TraceData.E_MsgName.eNaviN:
                            break;
                        case TraceData.E_MsgName.eNaviE:
                            break;
                        case TraceData.E_MsgName.eNaviPsi:
                            break;
                        case TraceData.E_MsgName.eMotorMainBatVolt:
                            break;
                        case TraceData.E_MsgName.eMotorSecBatVolt:
                            break;
                        case TraceData.E_MsgName.eMotorCurrent:
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
                            break;
                        case TraceData.E_MsgName.eDistTof2:
                            break;
                        case TraceData.E_MsgName.eDistTof3:
                            break;
                        case TraceData.E_MsgName.eMotorSysCurrent:
                            break;
                        case TraceData.E_MsgName.eMotorServoCurrent:
                            break;
                        case TraceData.E_MsgName.eLineNumOfLine:
                            break;
                        case TraceData.E_MsgName.eLinePositionOfLine1:
                            break;
                        case TraceData.E_MsgName.eLinePositionOfLine2:
                            break;
                        case TraceData.E_MsgName.eCollWarnSharp1:
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
