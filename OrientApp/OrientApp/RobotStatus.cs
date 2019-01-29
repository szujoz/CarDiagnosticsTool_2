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
        public NaviState NaviState { get; set; }
        public double EncoderVelocity { get; set; }
        public int DistTof1 { get; set; }
        public int DistTof2 { get; set; }
        public int DistTof3 { get; set; }
        public int DistSharp1 { get; set; }
        public Vector3D InertAccel { get; set; }
        public Vector3D InertAngularVelocity { get; set; }
        public double SteeringWheelAngle { get; set; }
        public double ServoAngle { get; set; }

        public double MotorMainBatVolt { get; set; }
        public double MotorSecBatVolt { get; set; }
        public double MotorCurrent { get; set; }
        public int MotorSysCurrent { get; set; }
        public int MotorServoCurrent { get; set; }

        public int LineNumberOfLines { get; set; }
        public double LineMainLinePos { get; set; }
        public double LineSecLinePos { get; set; }

        public int MazeMainSM { get; set; }
        public double MazeGetKp { get; set; }
        public double MazeGetKd { get; set; }
        public int MazeGetSpeed { get; set; }
        public Int64 MazeSegments { get; set; }
        public int MazeActState { get; set; }
        public double MazeActKp { get; set; }
        public double MazeActKd { get; set; }
        public int MazeActSpeed { get; set; }
        public int MazeInclinSegment { get; set; }

        public int SRunMainSM { get; set; }
        public int SRunActState { get; set; }
        public double SRunActP { get; set; }
        public double SRunActKp { get; set; }
        public double SRunActKd { get; set; }
        public int SRunActSpeed { get; set; }
        public double SRunGetP { get; set; }
        public double SRunGetKp { get; set; }
        public double SRunGetKd { get; set; }
        public int SRunGetSpeed { get; set; }

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
            foreach (var msg in TraceInfo.RecMsgOrder)
            {
                if (msg.Type == TraceData.E_MsgType.eFloat)
                {
                    switch (msg.RxName)
                    {
                        case TraceData.E_RecMsgName.eNaviN:
                            NaviState.Poistion.Y = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eNaviE:
                            NaviState.Poistion.X = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eNaviPsi:
                            NaviState.Orientation = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eEncoderVelocity:
                            EncoderVelocity = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eInertAccelerationX:
                            InertAccel.X = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eInertAccelerationY:
                            InertAccel.Y = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eInertAccelerationZ:
                            InertAccel.Z = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eInertAngularVelocityX:
                            InertAngularVelocity.X = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eInertAngularVelocityY:
                            InertAngularVelocity.Y = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eInertAngularVelocityZ:
                            InertAngularVelocity.Z = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eSteeringWheelAngle:
                            ServoAngle = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eServoAngle:
                            ServoAngle = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;

                        case TraceData.E_RecMsgName.eMotorMainBatVolt:
                            MotorMainBatVolt = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eMotorSecBatVolt:
                            MotorSecBatVolt = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eMotorCurrent:
                            MotorCurrent = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;

                        case TraceData.E_RecMsgName.eLineMainLinePos:
                            LineMainLinePos = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eLineSecLinePos:
                            LineSecLinePos = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;

                        case TraceData.E_RecMsgName.eMazeGetKp:
                            MazeGetKp = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eMazeGetKd:
                            MazeGetKd = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eMazeActKp:
                            MazeActKp = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eMazeActKd:
                            MazeActKd = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;

                        case TraceData.E_RecMsgName.eSRunActP:
                            SRunActP = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eSRunActKp:
                            SRunActKp = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eSRunActKd:
                            SRunActKd = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eSRunGetP:
                            SRunGetP = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eSRunGetKp:
                            SRunGetKp = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_RecMsgName.eSRunGetKd:
                            SRunGetKd = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;


                        default:
                            break;
                    }
                }
                else
                {
                    switch (msg.RxName)
                    {
                        case TraceData.E_RecMsgName.eDistTof1:
                            DistTof1 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_RecMsgName.eDistTof2:
                            DistTof2 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_RecMsgName.eDistTof3:
                            DistTof3 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_RecMsgName.eDistSharp1:
                            DistSharp1 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;

                        case TraceData.E_RecMsgName.eMotorSysCurrent:
                            MotorSysCurrent = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_RecMsgName.eMotorServoCurrent:
                            MotorServoCurrent = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;

                        case TraceData.E_RecMsgName.eLineNumOfLine:
                            LineNumberOfLines = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;

                        case TraceData.E_RecMsgName.eMazeMainSM:
                            MazeMainSM = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_RecMsgName.eMazeGetSpeed:
                            MazeGetSpeed = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_RecMsgName.eMazeSegments:
                            MazeSegments = Converter.UnwrapLong(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_RecMsgName.eMazeActState:
                            MazeActState = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_RecMsgName.eMazeActSpeed:
                            MazeActSpeed = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_RecMsgName.eMazeInclinSegment:
                            MazeInclinSegment = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;

                        case TraceData.E_RecMsgName.eSRunMainSM:
                            SRunMainSM = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_RecMsgName.eSRunActState:
                            SRunActState = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_RecMsgName.eSRunActSpeed:
                            SRunActSpeed = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_RecMsgName.eSRunGetSpeed:
                            SRunGetSpeed = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
