using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Ellipse : Circle
    {
        protected double _A;
        protected double _B;

        public Ellipse(double r, double d, double a, double b):base(r, d)
        {
            this._R = r;
            this._D = d;
            this._A = a;
            this._B = b;
        }

        public override double GetArea()
        {
            return Math.PI * _A * _B;
        }

        public override void Display()
        {
            Console.WriteLine($"Hello I'm Ellipse. My r: {_R}, d: {_D}, a: {_A}, b:{_B} and Area: {GetArea()}");
        }
    }
}
