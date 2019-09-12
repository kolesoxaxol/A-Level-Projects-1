using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    interface IProduct
    {
        void Sell();

        void SetDiscount(int discount);
    }
}
