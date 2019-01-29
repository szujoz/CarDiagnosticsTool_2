using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientApp
{
    public class Trace
    {
        // Singleton
        private static Trace Instance;

        public List<TraceData> RecMsgOrder { get; set; }

        public List<TraceData> TxMsgOrder { get; set; }

        private int msgLenght = 120;

        /// <summary>
        /// Instanciate the singleton class and init the properties.
        /// </summary>
        /// <returns> Trace object that knows how to decode the received messages. </returns>
        public static Trace GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Trace();
            }

            return Instance;
        }

        private Trace ()
        {
            RecMsgOrder = new List<TraceData>(msgLenght);
            TxMsgOrder = new List<TraceData>(msgLenght);

            UpdateRecMessageOrder();
            UpdateTxMessageOrder();
        }

        private void UpdateRecMessageOrder()
        {
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eNaviN, TraceData.E_MsgType.eFloat, 5, 5, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eNaviE, TraceData.E_MsgType.eFloat, 10, 5, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eNaviPsi, TraceData.E_MsgType.eFloat, 15, 5, 4));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eEncoderVelocity, TraceData.E_MsgType.eFloat, 20, 4, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eDistTof1, TraceData.E_MsgType.eInt, 24, 4));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eDistTof2, TraceData.E_MsgType.eInt, 28, 4));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eDistTof3, TraceData.E_MsgType.eInt, 32, 4));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eDistSharp1, TraceData.E_MsgType.eInt, 36, 4));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eInertAccelerationX, TraceData.E_MsgType.eFloat, 40, 6, 3));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eInertAccelerationY, TraceData.E_MsgType.eFloat, 46, 6, 3));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eInertAccelerationZ, TraceData.E_MsgType.eFloat, 52, 6, 3));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eInertAngularVelocityX, TraceData.E_MsgType.eFloat, 58, 6, 4));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eInertAngularVelocityY, TraceData.E_MsgType.eFloat, 64, 6, 4));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eInertAngularVelocityZ, TraceData.E_MsgType.eFloat, 70, 6, 4));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eSteeringWheelAngle, TraceData.E_MsgType.eFloat, 76, 5, 4));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eServoAngle, TraceData.E_MsgType.eFloat, 81, 5, 4));

            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMotorMainBatVolt, TraceData.E_MsgType.eFloat, 86, 5, 3));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMotorSecBatVolt, TraceData.E_MsgType.eFloat, 91, 5, 3));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMotorCurrent, TraceData.E_MsgType.eFloat, 96, 9, 3));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMotorSysCurrent, TraceData.E_MsgType.eInt, 105, 4));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMotorServoCurrent, TraceData.E_MsgType.eInt, 109, 4));

            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eLineNumOfLine, TraceData.E_MsgType.eInt, 113, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eLineMainLinePos, TraceData.E_MsgType.eFloat, 115, 6, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eLineSecLinePos, TraceData.E_MsgType.eFloat, 121, 6, 2));

            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMazeMainSM, TraceData.E_MsgType.eInt, 127, 1));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMazeGetKp, TraceData.E_MsgType.eFloat, 128, 5, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMazeGetKd, TraceData.E_MsgType.eFloat, 133, 5, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMazeGetSpeed, TraceData.E_MsgType.eInt, 138, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMazeSegments, TraceData.E_MsgType.eInt, 140, 12));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMazeActState, TraceData.E_MsgType.eInt, 152, 1));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMazeActKp, TraceData.E_MsgType.eFloat, 153, 5, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMazeActKd, TraceData.E_MsgType.eFloat, 158, 5, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMazeActSpeed, TraceData.E_MsgType.eInt, 163, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eMazeInclinSegment, TraceData.E_MsgType.eInt, 165, 2));

            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eSRunMainSM, TraceData.E_MsgType.eInt, 167, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eSRunActState, TraceData.E_MsgType.eInt, 169, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eSRunActP, TraceData.E_MsgType.eFloat, 171, 6, 3));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eSRunActKp, TraceData.E_MsgType.eFloat, 176, 5, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eSRunActKd, TraceData.E_MsgType.eFloat, 181, 5, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eSRunActSpeed, TraceData.E_MsgType.eInt, 186, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eSRunGetP, TraceData.E_MsgType.eFloat, 188, 6, 3));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eSRunGetKp, TraceData.E_MsgType.eFloat, 194, 5, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eSRunGetKd, TraceData.E_MsgType.eFloat, 199, 5, 2));
            RecMsgOrder.Add(new TraceData(TraceData.E_RecMsgName.eSRunGetSpeed, TraceData.E_MsgType.eInt, 204, 2));
        }

        private void UpdateTxMessageOrder ()
        {
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eStopCar, TraceData.E_MsgType.eInt, 5, 1));

            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eMazeMainSMReset, TraceData.E_MsgType.eInt, 6, 1));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eMazeMainSMResetTo, TraceData.E_MsgType.eInt, 7, 1));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eMazeGetState, TraceData.E_MsgType.eInt, 8, 1));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eMazeSetState, TraceData.E_MsgType.eInt, 9, 1));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eMazeSetKp, TraceData.E_MsgType.eFloat, 10, 5, 2));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eMazeSetKd, TraceData.E_MsgType.eFloat, 15, 5, 2));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eMazeSetSpeed, TraceData.E_MsgType.eInt, 20, 2));

            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eSRunTryOvertake, TraceData.E_MsgType.eInt, 22, 1));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eSRunHardReset, TraceData.E_MsgType.eInt, 23, 1));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eSRunSoftReset, TraceData.E_MsgType.eInt, 24, 1));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eSRunSoftResetTo, TraceData.E_MsgType.eInt, 25, 2));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eSRunGetState, TraceData.E_MsgType.eInt, 27, 2));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eSRunSetState, TraceData.E_MsgType.eInt, 29, 2));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eSRunSetP, TraceData.E_MsgType.eFloat, 31, 6, 2));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eSRunSetKp, TraceData.E_MsgType.eFloat, 37, 5, 2));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eSRunSetKp, TraceData.E_MsgType.eFloat, 42, 5, 2));
            TxMsgOrder.Add(new TraceData(TraceData.E_TxMsgName.eSRunSetSpeed, TraceData.E_MsgType.eInt, 47, 2));
        }
    }
}
