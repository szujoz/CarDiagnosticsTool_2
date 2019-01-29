using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientApp
{
    public class ByteConverter
    {
        // Singleton
        private static ByteConverter Instance;

        /// <summary>
        /// Instanciate the singleton class and init the properties.
        /// </summary>
        /// <returns> ByteConverter object that provides coverter methods. </returns>
        public static ByteConverter GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ByteConverter();
            }

            return Instance;
        }

        private ByteConverter() { }

        public byte[] ConvertFloatToBytes(double floatPoint, int len, int dec)
        {
            int modif;
            int bound;
            byte[] result = new byte[len];

            if (floatPoint >= 0)
            {
                bound = DetermineBound(len, false);

                if (floatPoint * Math.Pow(10, dec) > bound)
                {
                    modif = bound;
                }
                else
                {
                    modif = Convert.ToInt32(floatPoint * Math.Pow(10, dec));
                }
            }
            else
            {
                bound = DetermineBound(len, true);

                if (floatPoint * Math.Pow(10, dec) < bound)
                {
                    modif = bound;
                }
                else
                {
                    modif = Convert.ToInt32(floatPoint * Math.Pow(10, dec));
                }
            }

            result = ConvertIntToBytes(modif, len);

            return result;
        }

        public byte[] ConvertIntToBytes (int integer, int len)
        {
            int bound;
            int locValue = integer;
            byte[] result = new byte[len];

            if (integer >= 0)
            {
                bound = DetermineBound(len, false);
                if (locValue > bound)
                {
                    locValue = bound;
                }
            }
            else
            {
                bound = DetermineBound(len, true);
                if (locValue < bound)
                {
                    locValue = Math.Abs(bound);
                }
                else
                {
                    locValue = Math.Abs(locValue);
                }
            }

            for (int i = len-1; i >= 0; i--)
            {
                result[i] = Convert.ToByte(locValue % 10 + '0');
                locValue /= 10;
            }

            if (integer < 0)
            {
                result[0] = Convert.ToByte('-');
            }

            return result;
        }

        public byte ConvertBoolToByte (bool boolValue)
        {
            byte result;

            if (boolValue == true)
            {
                result = 1 + '0';
            }
            else
            {
                result = 0 + '0';
            }

            return result;
        }

        private int DetermineBound (int len, bool isNegativ)
        {
            int bound = 0;

            if (isNegativ == false)
            {
                bound = Convert.ToInt32(Math.Pow(10, len)) - 1;
            }
            else
            {
                bound = -Convert.ToInt32(Math.Pow(10, len-1)) + 1;
            }

            return bound;
        }

        public double UnwrapFloat (byte[] array, int ofs, int len, int dec)
        {
            double result = 0;

            if (array != null)
            {
                byte[] temp = new byte[len];

                for (int i = 0; i < len; i++)
                {
                    temp[i] = array[ofs + i];
                }

                result = UnwrapInt(temp, 0, len);

                for (int i = 0; i < dec; i++)
                {
                    result /= 10;
                }
            }

            return result;
        }

        public int UnwrapInt (byte[] array, int ofs, int len)
        {
            int result = 0;
            
            if (array != null)
            {
                result = (int)UnwrapLong(array, ofs, len);
            }

            return result;
        }

        public Int64 UnwrapLong(byte[] array, int ofs, int len)
        {
            Int64 result = 0;

            if (array != null)
            {
                byte[] temp = new byte[len];

                for (int i = 0; i < len; i++)
                {
                    temp[i] = array[ofs + i];
                }

                if (Encoding.Default.GetString(temp)[0] == '-')
                {
                    for (int i = 1; i < len; i++)
                    {
                        result *= 10;
                        result += Encoding.ASCII.GetString(temp)[i] - '0';
                    }

                    result *= -1;
                }
                else
                {
                    for (int i = 0; i < len; i++)
                    {
                        result *= 10;
                        result += Encoding.ASCII.GetString(temp)[i] - '0';
                    }
                }
            }

            return result;
        }
    }
}
