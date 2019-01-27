using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientApp
{
    public class Vector2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector2D ()
        {
            X = 0;
            Y = 0;
        }

        public Vector2D (double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
