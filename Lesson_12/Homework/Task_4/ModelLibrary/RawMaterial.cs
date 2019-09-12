using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class RawMaterial : Product
    {
        public struct Size
        {
            public int height;
            public int width;
        }

        public RawMaterial(string name, string type, Size size, double price) : base(name, type, price)
        {

        }
    }
}
