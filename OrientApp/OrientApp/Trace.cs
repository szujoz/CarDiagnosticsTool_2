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

        public List<TraceData> MsgOrder { get; set; }

        private int index;

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
            MsgOrder = new List<TraceData>(msgLenght);

            UpdateMessageOrder();

            // Header (2) + Size (3)
            index = 5;
        }

        private void UpdateMessageOrder()
        {
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eNaviN, TraceData.E_MsgType.eFloat, 5, 5, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eNaviE, TraceData.E_MsgType.eFloat, 10, 5, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eNaviPsi, TraceData.E_MsgType.eFloat, 15, 5, 4));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eEncoderVelocity, TraceData.E_MsgType.eFloat, 20, 4, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eDistTof1, TraceData.E_MsgType.eInt, 24, 4));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eDistTof2, TraceData.E_MsgType.eInt, 28, 4));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eDistTof3, TraceData.E_MsgType.eInt, 32, 4));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eDistSharp1, TraceData.E_MsgType.eInt, 36, 4));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eInertAccelerationX, TraceData.E_MsgType.eFloat, 40, 6, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eInertAccelerationY, TraceData.E_MsgType.eFloat, 46, 6, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eInertAccelerationZ, TraceData.E_MsgType.eFloat, 52, 6, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eInertAngularVelocityX, TraceData.E_MsgType.eFloat, 58, 6, 4));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eInertAngularVelocityY, TraceData.E_MsgType.eFloat, 64, 6, 4));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eInertAngularVelocityZ, TraceData.E_MsgType.eFloat, 70, 6, 4));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eSteeringWheelAngle, TraceData.E_MsgType.eFloat, 76, 5, 4));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eServoAngle, TraceData.E_MsgType.eFloat, 81, 5, 4));

            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMotorMainBatVolt, TraceData.E_MsgType.eFloat, 86, 5, 3));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMotorSecBatVolt, TraceData.E_MsgType.eFloat, 91, 5, 3));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMotorCurrent, TraceData.E_MsgType.eFloat, 96, 9, 3));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMotorSysCurrent, TraceData.E_MsgType.eInt, 105, 4));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMotorServoCurrent, TraceData.E_MsgType.eInt, 109, 4));

            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eLineNumOfLine, TraceData.E_MsgType.eInt, 113, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eLineMainLinePos, TraceData.E_MsgType.eFloat, 115, 6, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eLineSecLinePos, TraceData.E_MsgType.eFloat, 121, 6, 2));

            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMazeMainSM, TraceData.E_MsgType.eInt, 127, 1));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMazeGetKp, TraceData.E_MsgType.eFloat, 128, 5, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMazeGetKd, TraceData.E_MsgType.eFloat, 133, 5, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMazeGetSpeed, TraceData.E_MsgType.eInt, 138, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMazeSegments, TraceData.E_MsgType.eInt, 140, 12));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMazeActState, TraceData.E_MsgType.eInt, 152, 1));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMazeActKp, TraceData.E_MsgType.eFloat, 153, 5, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMazeActKd, TraceData.E_MsgType.eFloat, 158, 5, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMazeActSpeed, TraceData.E_MsgType.eInt, 163, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMazeInclinSegment, TraceData.E_MsgType.eInt, 165, 2));

            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eSRunMainSM, TraceData.E_MsgType.eInt, 167, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eSRunActState, TraceData.E_MsgType.eInt, 169, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eSRunActP, TraceData.E_MsgType.eFloat, 171, 6, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eSRunActKp, TraceData.E_MsgType.eFloat, 176, 5, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eSRunActKd, TraceData.E_MsgType.eFloat, 181, 5, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eSRunActSpeed, TraceData.E_MsgType.eInt, 186, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eSRunGetP, TraceData.E_MsgType.eFloat, 188, 6, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eSRunGetKp, TraceData.E_MsgType.eFloat, 194, 5, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eSRunGetKd, TraceData.E_MsgType.eFloat, 199, 5, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eSRunGetSpeed, TraceData.E_MsgType.eInt, 204, 2));
        }
    }
}
