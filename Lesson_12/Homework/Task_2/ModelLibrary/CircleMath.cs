using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public static class CircleMath
    {
        public static bool CheckIsEqual(Circle c1, Circle c2)
        {
            return GetArea(c1.R) == GetArea(c2.R);
        }

        private static double GetArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}