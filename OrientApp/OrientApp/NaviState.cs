using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientApp
{
    public class NaviState
    {
        public Vector2D Poistion { get; set; }
        public double Orientation { get; set; }

        public NaviState ()
        {
            Poistion = new Vector2D();
            Orientation = 0;
        }

        public NaviState (Vector2D p, double psi)
        {
            Poistion = p;
            Orientation = psi;
        }
    }
}
