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
        public int MazeSegments { get; set; }
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
            foreach (var msg in TraceInfo.MsgOrder)
            {
                if (msg.Type == TraceData.E_MsgType.eFloat)
                {
                    switch (msg.Name)
                    {
                        case TraceData.E_MsgName.eNaviN:
                            NaviState.Poistion.Y = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eNaviE:
                            NaviState.Poistion.X = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eNaviPsi:
                            NaviState.Orientation = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eEncoderVelocity:
                            EncoderVelocity = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
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
                        case TraceData.E_MsgName.eSteeringWheelAngle:
                            ServoAngle = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eServoAngle:
                            ServoAngle = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
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

                        case TraceData.E_MsgName.eLineMainLinePos:
                            LineMainLinePos = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eLineSecLinePos:
                            LineSecLinePos = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;

                        case TraceData.E_MsgName.eMazeGetKp:
                            MazeGetKp = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eMazeGetKd:
                            MazeGetKd = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eMazeActKp:
                            MazeActKp = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eMazeActKd:
                            MazeActKd = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;

                        case TraceData.E_MsgName.eSRunActP:
                            SRunActP = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eSRunActKp:
                            SRunActKp = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eSRunActKd:
                            SRunActKd = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eSRunGetP:
                            SRunGetP = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eSRunGetKp:
                            SRunGetKp = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;
                        case TraceData.E_MsgName.eSRunGetKd:
                            SRunGetKd = Converter.UnwrapFloat(bytes, msg.Offset, msg.Lenght, msg.Decimals);
                            break;


                        default:
                            break;
                    }
                }
                else
                {
                    switch (msg.Name)
                    {
                        case TraceData.E_MsgName.eDistTof1:
                            DistTof1 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eDistTof2:
                            DistTof2 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eDistTof3:
                            DistTof3 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eDistSharp1:
                            DistSharp1 = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
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

                        case TraceData.E_MsgName.eMazeMainSM:
                            MazeMainSM = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eMazeGetSpeed:
                            MazeGetSpeed = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eMazeSegments:
                            MazeSegments = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eMazeActState:
                            MazeActState = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eMazeActSpeed:
                            MazeActSpeed = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eMazeInclinSegment:
                            MazeInclinSegment = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;

                        case TraceData.E_MsgName.eSRunMainSM:
                            SRunMainSM = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eSRunActState:
                            SRunActState = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eSRunActSpeed:
                            SRunActSpeed = Converter.UnwrapInt(bytes, msg.Offset, msg.Lenght);
                            break;
                        case TraceData.E_MsgName.eSRunGetSpeed:
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
