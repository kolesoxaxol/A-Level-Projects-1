using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Triangle : Figure
    {
        private double _A;
        private double _B;
        private double _C;
        private double _H;

        public Triangle(double a, double b, double c, double h)
        {
            this._A = a;
            this._B = b;
            this._C = c;
            this._H = h;
        }

        public override double GetArea()
        {
            return _A * _H / 2;
        }

        public override void Display()
        {
            Console.WriteLine($"Hello I'm Triangle. My a: {_A}, b: {_B}, c: {_C}, h: {_H} and Area: {GetArea()}");
        }
    }
}
