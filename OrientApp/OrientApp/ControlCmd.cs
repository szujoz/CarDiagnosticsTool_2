using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientApp
{
    public class ControlCmd
    {
        // Singleton Objects.
        private static ControlCmd Instance;
        public Trace TraceInfo { get; set; }
        public ByteConverter Converter { get; set; }

        public bool StopCar { get; set; }

        public bool MazeMainSMReset { get; set; }
        public int MazeMainSMResetTo { get; set; }
        public int MazeGetState { get; set; }
        public int MazeSetState { get; set; }
        public double MazeSetKp { get; set; }
        public double MazeSetKd { get; set; }
        public int MazeSetSpeed { get; set; }

        public bool SRunTryOvertake { get; set; }
        public bool SRunHardReset { get; set; }
        public bool SRunSoftReset { get; set; }
        public int SRunSoftResetTo { get; set; }
        public int SRunGetState { get; set; }
        public int SRunSetState { get; set; }
        public double SRunSetP { get; set; }
        public double SRunSetKp { get; set; }
        public double SRunSetKd { get; set; }
        public int SRunSetSpeed { get; set; }

        /// <summary>
        /// Instanciate the singleton class and init the properties.
        /// </summary>
        /// <returns> RobotStatus object to store the informations about the car. </returns>
        public static ControlCmd GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ControlCmd();
            }

            return Instance;
        }

        private ControlCmd ()
        {
            TraceInfo = Trace.GetInstance();
            Converter = ByteConverter.GetInstance();
        }

        public byte[] GetTxMessageBytes ()
        {
            byte[] retVal;
            byte[] arr = new byte[1];
            int size = 0;
            int header = 2;
            int msgSize = 3;

            foreach (var item in TraceInfo.TxMsgOrder)
            {
                size += item.Lenght;
            }

            retVal = new byte[header + msgSize];

            retVal[0] = Convert.ToByte('B');
            retVal[1] = Convert.ToByte('B');
            retVal[4] = Convert.ToByte(size % 10 + '0');
            size /= 10;
            retVal[3] = Convert.ToByte(size % 10 + '0');
            size /= 10;
            retVal[2] = Convert.ToByte(size % 10 + '0');

            for (int i = 0; i < TraceInfo.TxMsgOrder.Count; i++)
            {
                switch (TraceInfo.TxMsgOrder[i].TxName)
                {
                    case TraceData.E_TxMsgName.eStopCar:
                        arr[0] = Converter.ConvertBoolToByte(StopCar);
                        retVal = retVal.Concat(arr).ToArray();
                        break;

                    case TraceData.E_TxMsgName.eMazeMainSMReset:
                        arr[0] = Converter.ConvertBoolToByte(MazeMainSMReset);
                        retVal = retVal.Concat(arr).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eMazeMainSMResetTo:
                        retVal = retVal.Concat(Converter.ConvertIntToBytes(MazeMainSMResetTo, TraceInfo.TxMsgOrder[i].Lenght)).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eMazeGetState:
                        retVal = retVal.Concat(Converter.ConvertIntToBytes(MazeGetState, TraceInfo.TxMsgOrder[i].Lenght)).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eMazeSetState:
                        retVal = retVal.Concat(Converter.ConvertIntToBytes(MazeSetState, TraceInfo.TxMsgOrder[i].Lenght)).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eMazeSetKp:
                        retVal = retVal.Concat(Converter.ConvertFloatToBytes(MazeSetKp, TraceInfo.TxMsgOrder[i].Lenght, TraceInfo.TxMsgOrder[i].Decimals)).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eMazeSetKd:
                        retVal = retVal.Concat(Converter.ConvertFloatToBytes(MazeSetKd, TraceInfo.TxMsgOrder[i].Lenght, TraceInfo.TxMsgOrder[i].Decimals)).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eMazeSetSpeed:
                        retVal = retVal.Concat(Converter.ConvertIntToBytes(MazeSetSpeed, TraceInfo.TxMsgOrder[i].Lenght)).ToArray();
                        break;

                    case TraceData.E_TxMsgName.eSRunTryOvertake:
                        arr[0] = Converter.ConvertBoolToByte(SRunTryOvertake);
                        retVal = retVal.Concat(arr).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eSRunHardReset:
                        arr[0] = Converter.ConvertBoolToByte(SRunHardReset);
                        retVal = retVal.Concat(arr).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eSRunSoftReset:
                        arr[0] = Converter.ConvertBoolToByte(SRunSoftReset);
                        retVal = retVal.Concat(arr).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eSRunSoftResetTo:
                        retVal = retVal.Concat(Converter.ConvertIntToBytes(SRunSoftResetTo, TraceInfo.TxMsgOrder[i].Lenght)).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eSRunGetState:
                        retVal = retVal.Concat(Converter.ConvertIntToBytes(SRunGetState, TraceInfo.TxMsgOrder[i].Lenght)).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eSRunSetState:
                        retVal = retVal.Concat(Converter.ConvertIntToBytes(SRunSetState, TraceInfo.TxMsgOrder[i].Lenght)).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eSRunSetP:
                        retVal = retVal.Concat(Converter.ConvertFloatToBytes(SRunSetP, TraceInfo.TxMsgOrder[i].Lenght, TraceInfo.TxMsgOrder[i].Decimals)).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eSRunSetKp:
                        retVal = retVal.Concat(Converter.ConvertFloatToBytes(SRunSetKp, TraceInfo.TxMsgOrder[i].Lenght, TraceInfo.TxMsgOrder[i].Decimals)).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eSRunSetKd:
                        retVal = retVal.Concat(Converter.ConvertFloatToBytes(SRunSetKd, TraceInfo.TxMsgOrder[i].Lenght, TraceInfo.TxMsgOrder[i].Decimals)).ToArray();
                        break;
                    case TraceData.E_TxMsgName.eSRunSetSpeed:
                        retVal = retVal.Concat(Converter.ConvertIntToBytes(SRunSetSpeed, TraceInfo.TxMsgOrder[i].Lenght)).ToArray();
                        break;
                    default:
                        break;
                }
            }

            arr[0] = Convert.ToByte('\r');
            retVal = retVal.Concat(arr).ToArray();
            arr[0] = Convert.ToByte('\n');
            retVal = retVal.Concat(arr).ToArray();

            return retVal;
        }

        public void ProcessCommand (TraceData.E_TxMsgName name, string cmd)
        {
            switch (name)
            {
                case TraceData.E_TxMsgName.eStopCar:
                    if (cmd == "true") StopCar = true;
                    else StopCar = false;
                    break;

                case TraceData.E_TxMsgName.eMazeMainSMReset:
                    if (cmd == "true") MazeMainSMReset = true;
                    else MazeMainSMReset = false;
                    break;
                case TraceData.E_TxMsgName.eMazeMainSMResetTo:
                    MazeMainSMResetTo = Convert.ToInt32(cmd);
                    break;
                case TraceData.E_TxMsgName.eMazeGetState:
                    MazeGetState = Convert.ToInt32(cmd);
                    break;
                case TraceData.E_TxMsgName.eMazeSetState:
                    MazeSetState = Convert.ToInt32(cmd);
                    break;
                case TraceData.E_TxMsgName.eMazeSetKp:
                    MazeSetKp = Convert.ToDouble(cmd);
                    break;
                case TraceData.E_TxMsgName.eMazeSetKd:
                    MazeSetKd = Convert.ToDouble(cmd);
                    break;
                case TraceData.E_TxMsgName.eMazeSetSpeed:
                    MazeSetSpeed = Convert.ToInt32(cmd);
                    break;

                case TraceData.E_TxMsgName.eSRunTryOvertake:
                    if (cmd == "true") SRunTryOvertake = true;
                    else SRunTryOvertake = false;
                    break;
                case TraceData.E_TxMsgName.eSRunHardReset:
                    if (cmd == "true") SRunHardReset = true;
                    else SRunHardReset = false;
                    break;
                case TraceData.E_TxMsgName.eSRunSoftReset:
                    if (cmd == "true") SRunSoftReset = true;
                    else SRunSoftReset = false;
                    break;
                case TraceData.E_TxMsgName.eSRunSoftResetTo:
                    SRunSoftResetTo = Convert.ToInt32(cmd);
                    break;
                case TraceData.E_TxMsgName.eSRunGetState:
                    SRunGetState = Convert.ToInt32(cmd);
                    break;
                case TraceData.E_TxMsgName.eSRunSetState:
                    SRunSetState = Convert.ToInt32(cmd);
                    break;
                case TraceData.E_TxMsgName.eSRunSetP:
                    SRunSetP = Convert.ToDouble(cmd);
                    break;
                case TraceData.E_TxMsgName.eSRunSetKp:
                    SRunSetKp = Convert.ToDouble(cmd);
                    break;
                case TraceData.E_TxMsgName.eSRunSetKd:
                    SRunSetKd = Convert.ToDouble(cmd);
                    break;
                case TraceData.E_TxMsgName.eSRunSetSpeed:
                    SRunSetSpeed = Convert.ToInt32(cmd);
                    break;
                default:
                    break;
            }
        }
    }
}
