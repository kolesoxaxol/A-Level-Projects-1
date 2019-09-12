using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Furniture : Product
    {

        public string Manufacturer { get; private set; }

        public string Color { get; private set; }

        public bool Warranty { get; private set; }

        public Furniture(string name, string type, string manufacturer, string color, double price, bool warranty):base(name, type, price)
        {
            this.Manufacturer = manufacturer;
            this.Color = color;
            this.Warranty = warranty;
        }

        public override void SetDiscount(int discount)
        {
            double discountPrice = this.Price / 100 * discount;
            this.Price -= discountPrice;
            this.Discount = discountPrice;
            this.DiscountValue = true;

            Console.WriteLine($"New price: {this.Price} rub. with discount: {discountPrice} rub.");
        }
    }
}
