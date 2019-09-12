using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Circle : Figure
    {
        protected double _R;
        protected double _D;

        public Circle(double r, double d)
        {
            this._R = r;
            this._D = d;
        }

        public Circle()
        {
        
        }

        public override double GetArea()
        {
            return Math.PI * (Math.Pow(_R,2));
        }

        public override void Display()
        {
            Console.WriteLine($"Hello I'm Circle. My r: {_R}, d: {_D}, and Area: {GetArea()}");
        }
    }
}
