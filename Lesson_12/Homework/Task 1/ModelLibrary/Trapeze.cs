using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ModelLibrary
{
    public class Trapeze
    {
        Point pointA, pointB, pointC, pointD;

        private double[] sides = new double[4];

        public Trapeze(Point pointA, Point pointB, Point pointC, Point pointD)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.pointC = pointC;
            this.pointD = pointD;
        }

        public bool CheckTrapeze()
        {
            return (GetDistance(pointA, pointB) == GetDistance(pointC, pointD));
        }

        private double GetDistance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow((pointA._x - pointB._x), 2) + Math.Pow((pointA._y - pointB._y), 2));
        }

        public double GetPerimeter()
        {
            return GetDistance(pointA, pointB) + GetDistance(pointB, pointC) + GetDistance(pointC, pointD) + GetDistance(pointD, pointC);
        }

        public double GetArea()
        {
            return (GetDistance(pointB, pointC) + GetDistance(pointA, pointD)) * 0.5 * (pointB._y - pointA._y);
        }
    }
}
