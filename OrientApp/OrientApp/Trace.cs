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
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eDistSharp1, TraceData.E_MsgType.eInt, 5, 5, 0));
            MsgOrder.Add(new TraceData(TraceData.E_MsgName.eInertAccelerationX, TraceData.E_MsgType.eFloat, 16, 4, 2));
        }
    }
}
