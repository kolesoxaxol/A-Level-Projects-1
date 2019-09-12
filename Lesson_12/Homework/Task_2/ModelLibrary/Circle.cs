using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ModelLibrary
{
    public struct Point
    {
        public int x;
        public int y;
    }

    public class Circle
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public double R { get; private set; }

        public Circle(Point point, double r)
        {
            if (point.y > r && r < 0)
            {
                Console.WriteLine("Radius can't be negative");
            }

            this.R = r;
            this.X = point.x;
            this.Y = point.y;
        }

        public static bool operator ==(Circle c1, Circle c2)
        {
            if (c1.R == c2.R && c1.X == c2.X && c1.Y == c2.Y)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Circle c1, Circle c2)
        {
            if (!(c1.R == c2.R && c1.X == c2.X && c1.Y == c2.Y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
