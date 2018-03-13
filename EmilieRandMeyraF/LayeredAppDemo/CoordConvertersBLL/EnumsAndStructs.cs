using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordConvertersBLL
{
    public enum Quandrant
    {
        N,
        S,
        E,
        W
    }

    public struct DMSCoord
    {
        public int deg;
        public int min;
        public double sec;
        public Quandrant quandrant;
    }


}
