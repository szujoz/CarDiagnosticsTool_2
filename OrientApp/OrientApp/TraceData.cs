using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientApp
{
    public class TraceData
    {
        public enum E_MsgName
        {
            eNaviN = 0,
            eNaviE,
            eNaviPsi,
            eEncoderVelocity,
            eDistTof1,
            eDistTof2,
            eDistTof3,
            eDistSharp1,
            eInertAccelerationX,
            eInertAccelerationY,
            eInertAccelerationZ,
            eInertAngularVelocityX,
            eInertAngularVelocityY,
            eInertAngularVelocityZ,
            eSteeringWheelAngle,
            eServoAngle,

            eMotorMainBatVolt,
            eMotorSecBatVolt,
            eMotorCurrent,
            eMotorSysCurrent,
            eMotorServoCurrent,

            eLineNumOfLine,
            eLineMainLinePos,
            eLineSecLinePos,

            eMazeMainSM,
            eMazeGetKp,
            eMazeGetKd,
            eMazeGetSpeed,
            eMazeSegments,
            eMazeActState,
            eMazeActKp,
            eMazeActKd,
            eMazeActSpeed,
            eMazeInclinSegment,

            eSRunMainSM,
            eSRunActState,
            eSRunActP,
            eSRunActKp,
            eSRunActKd,
            eSRunActSpeed,
            eSRunGetP,
            eSRunGetKp,
            eSRunGetKd,
            eSRunGetSpeed

        };

        public enum E_MsgType
        {
            eFloat = 0,
            eInt
        }

        public int Offset { get; set; }
        public int Lenght { get; set; }
        public int Decimals { get; set; }
        public E_MsgName Name { get; set; }
        public E_MsgType Type { get; set; }

        public TraceData (E_MsgName name, E_MsgType type, int ofs, int len, int dec = 0)
        {
            Name = name;
            Type = type;
            Offset = ofs;
            Lenght = len;
            Decimals = dec;
        }
    }
}
