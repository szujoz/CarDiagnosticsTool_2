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

        public byte[] ConvertToBytes ()
        {

            return null;
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
