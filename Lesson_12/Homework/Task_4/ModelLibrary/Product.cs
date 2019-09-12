using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public abstract class Product : IProduct
    {
        public string Name { get; private set; }

        public string Type { get; private set; }

        public double Price { get; set; }

        public bool DiscountValue { get; set; } = false;

        public double Discount { get; set; }

        protected Product(string name, string type, double price)
        {
            this.Name = name;
            this.Type = type;
            this.Price = price;
        }

        public void Sell()
        {
            Console.WriteLine($"Sales! - Name: {Name}, Type: {Type}, Price: {Price}");
        }

        public virtual void SetDiscount(int discount)
        {
            Console.WriteLine("This product can't have a discount");
        }
    }
}
