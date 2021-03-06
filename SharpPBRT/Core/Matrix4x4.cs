﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPBRT.Core
{
    public struct Matrix4x4
    {
        public float[,] m;
        public Matrix4x4(float[,] m)
        {
            this.m = new float[4, 4];
            Array.Copy(m, this.m, 4 * 4);
        }
        public Matrix4x4(float t00, float t01, float t02, float t03,
              float t10, float t11, float t12, float t13,
              float t20, float t21, float t22, float t23,
              float t30, float t31, float t32, float t33)
        {
            m = new float[4, 4];
            m[0, 0] = t00; m[0, 1] = t01; m[0, 2] = t02; m[0, 3] = t03;
            m[1, 0] = t10; m[1, 1] = t11; m[1, 2] = t12; m[1, 3] = t13;
            m[2, 0] = t20; m[2, 1] = t21; m[2, 2] = t22; m[2, 3] = t23;
            m[3, 0] = t30; m[3, 1] = t31; m[3, 2] = t32; m[3, 3] = t33;
        }

        public static Matrix4x4 Mul(Matrix4x4 m1, Matrix4x4 m2)
        {
            Matrix4x4 r = new Matrix4x4();
            for (int i = 0; i < 4; ++i)
                for (int j = 0; j < 4; ++j)
                    r.m[i, j] = m1.m[i, 0] * m2.m[0, j] +
                               m1.m[i, 1] * m2.m[1, j] +
                               m1.m[i, 2] * m2.m[2, j] +
                               m1.m[i, 3] * m2.m[3, j];
            return r;
        }
    }
}
