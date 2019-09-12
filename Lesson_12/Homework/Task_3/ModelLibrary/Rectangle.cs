using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Rectangle : Figure
    {
        protected double _A;
        protected double _B;
        protected double _C;
        protected double _D;

        public Rectangle(double a, double b, double c, double d)
        {
            this._A = a;
            this._B = b;
            this._C = c;
            this._D = d;
        }

        public Rectangle()
        {

        }

        public override double GetArea()
        {
            return _A * _B;
        }

        public override void Display()
        {
            Console.WriteLine($"Hello I'm Rectagle. My a: {_A}, b: {_B}, c: {_C}, d: {_D} and Area: {GetArea()}");
        }
    }
}
