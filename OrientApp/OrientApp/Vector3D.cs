using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientApp
{
    public class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3D ()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Vector3D (double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
