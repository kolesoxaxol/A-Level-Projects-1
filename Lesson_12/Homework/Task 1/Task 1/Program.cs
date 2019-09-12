using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary;

namespace Task_1
{
    class Program
    {
        // 00 11 21 30
        static void Main(string[] args)
        {
            Point pointA = new Point(0, 0);
            Point pointB = new Point(1, 1);
            Point pointC = new Point(2, 1);
            Point pointD = new Point(3, 0);

            Trapeze trapeze = new Trapeze(pointA, pointB, pointC, pointD);

            bool check = trapeze.CheckTrapeze();
            double area = trapeze.GetArea();
            double perimetr = trapeze.GetPerimeter();

            Console.WriteLine($"{check}, {area.ToString()}, {perimetr.ToString()}");
        }
    }
}
