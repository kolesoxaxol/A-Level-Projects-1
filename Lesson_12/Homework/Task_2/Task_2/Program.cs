using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Struct with points value
            Point pCircle1 = new Point { x = 0, y = 0 };
            Point pCircle2 = new Point { x = 3, y = 5 };
            Point pCircle3 = new Point { x = 3, y = 5 };

            // Create local Circle type variables 
            Circle c1 = new Circle(pCircle1, 12);
            Circle c2 = new Circle(pCircle2, 11);
            Circle c3 = new Circle(pCircle3, 11);

            // Check circles is equal
            bool check;

            Console.WriteLine($"Compare with overload");
            check = c1 == c2;
            Console.WriteLine($"Circle 1 and Circle2 = {check}");

            Console.WriteLine("Compare with function");
            check = CircleMath.CheckIsEqual(c1, c2);
            Console.WriteLine($"Circle 1 and Circle2 = {check}");

            Console.WriteLine();

            Console.WriteLine($"Compare with overload");
            check = c2 == c3;
            Console.WriteLine($"Circle 2 and Circle3 = {check}");

            Console.WriteLine("Compare with function");
            check = CircleMath.CheckIsEqual(c2, c3);
            Console.WriteLine($"Circle 2 and Circle3 = {check}");

            Console.ReadKey();
        }
    }
}
