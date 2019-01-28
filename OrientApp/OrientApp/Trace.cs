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
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eDistSharp1, TraceData.E_MsgType.eInt, 5, 5));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eInertAccelerationX, TraceData.E_MsgType.eFloat, 16, 4, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eInertAccelerationY, TraceData.E_MsgType.eFloat, 20, 4, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eInertAccelerationZ, TraceData.E_MsgType.eFloat, 24, 4, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eInertAngularVelocityX, TraceData.E_MsgType.eFloat, 28, 4, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eInertAngularVelocityY, TraceData.E_MsgType.eFloat, 32, 4, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eInertAngularVelocityZ, TraceData.E_MsgType.eFloat, 36, 4, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eNaviN, TraceData.E_MsgType.eFloat, 40, 5, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eNaviE, TraceData.E_MsgType.eFloat, 45, 5, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eNaviPsi, TraceData.E_MsgType.eFloat, 50, 5, 4));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eEncoderVelocity, TraceData.E_MsgType.eFloat, 55, 5, 2));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eDistTof1, TraceData.E_MsgType.eInt, 60, 5));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eDistTof2, TraceData.E_MsgType.eInt, 65, 5));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eDistTof3, TraceData.E_MsgType.eInt, 70, 5));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMotorMainBatVolt, TraceData.E_MsgType.eFloat, 75, 5, 3));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMotorSecBatVolt, TraceData.E_MsgType.eFloat, 80, 5, 3));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMotorCurrent, TraceData.E_MsgType.eFloat, 85, 9, 3));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMotorSysCurrent, TraceData.E_MsgType.eInt, 94, 4));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eMotorServoCurrent, TraceData.E_MsgType.eInt, 98, 4));
            //TODO
        }
    }
}
