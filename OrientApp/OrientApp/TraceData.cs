using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientApp
{
    public class TraceData
    {
        public enum E_RecMsgName
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

        public enum E_TxMsgName
        {
            eStopCar = 0,

            eMazeMainSMReset,
            eMazeMainSMResetTo,
            eMazeGetState,
            eMazeSetState,
            eMazeSetKp,
            eMazeSetKd,
            eMazeSetSpeed,

            eSRunTryOvertake,
            eSRunHardReset,
            eSRunSoftReset,
            eSRunSoftResetTo,
            eSRunGetState,
            eSRunSetState,
            eSRunSetP,
            eSRunSetKp,
            eSRunSetKd,
            eSRunSetSpeed
        }

        public enum E_MsgType
        {
            eFloat = 0,
            eInt
        }

        public int Offset { get; set; }
        public int Lenght { get; set; }
        public int Decimals { get; set; }
        public E_RecMsgName RxName { get; set; }
        public E_TxMsgName TxName { get; set; }
        public E_MsgType Type { get; set; }

        public TraceData (E_RecMsgName name, E_MsgType type, int ofs, int len, int dec = 0)
        {
            RxName = name;
            Type = type;
            Offset = ofs;
            Lenght = len;
            Decimals = dec;
        }

        public TraceData (E_TxMsgName name, E_MsgType type, int ofs, int len, int dec = 0)
        {
            TxName = name;
            Type = type;
            Offset = ofs;
            Lenght = len;
            Decimals = dec;
        }
    }
}
