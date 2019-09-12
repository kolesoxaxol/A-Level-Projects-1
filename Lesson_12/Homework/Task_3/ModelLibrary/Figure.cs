using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public abstract class Figure : IFigure
    {
        public Figure()
        {
            
        }
        public virtual double GetArea()
        {
            return 0;
        }

        public virtual void Display()
        {
            Console.WriteLine("Hello I'm Abstract Class");
        }
    }
}
