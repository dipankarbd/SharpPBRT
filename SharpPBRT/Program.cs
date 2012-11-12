using SharpPBRT.Core;
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
           
            Vector v4 = v3 / 5.0f;
            int x = 0;
            int y = 1;
            Utility.Swap<int>(ref x, ref y);

            Vector v5 = -v2;
            Point p =new Point(1,2,3);
            Ray r = new Ray(p, v, 0.0f);
            ;
            r.DoSomething();

            int[,] m = new int[4,4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m[i, j] = i * j;
                }
            }
            int[,] n = new int[4, 4];
            Array.Copy(m, n,2);

            Utility.Swap<int>(ref m[0, 0], ref  m[3, 3]);
        }
    }
}
