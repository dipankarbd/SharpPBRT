using SharpPBRT.Core.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPBRT
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector(1,2,3);
            Vector v2 = 5.0f * v;
            Vector v3 = v * 5.0f;
            if (v2.Equals(v3))
            {

            }
            Vector v4 = v3 / 5.0f;
            Vector v5 = -v2;
        }
    }
}
