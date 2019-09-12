using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Square : Rectangle
    {
        public Square(double a, double b)
        {
            this._A = a;
            this._B = b;
        }

        public override double GetArea()
        {
            return Math.Pow(_A, 2);
        }

        public override void Display()
        {
            Console.WriteLine($"Hello I'm Square. My a: {_A}, b: {_B}, and Area: {GetArea()}");
        }
    }
}
