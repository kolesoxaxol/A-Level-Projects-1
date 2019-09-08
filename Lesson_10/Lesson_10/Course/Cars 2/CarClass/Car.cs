using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    public class Car
    {
        public string Type { get; private protected set; }
        public string Modele { get; private protected set; }
        public string Color { get; private protected set; }
        public int Price { get; set; }
        public int Discount { get; private protected set; }

        private protected int _discount = 0;

        Random rnd = new Random();

        public Car(string modele, string color, int price)
        {
            this.Modele = modele;
            this.Color = color;
            this.Price = price;
            this.Discount = _discount;
        }

        public Car()
        {
 
        }

        public void SetDiscount()
        {
            int discount = rnd.Next(1, 90);
            this.Discount = discount;

            int price = this.Price;
            int newCarPrice = price - (price / 100 * discount);

            this.Price = newCarPrice;
        }

        public void SetDiscount(int discount)
        {
            this.Discount = discount;

            int price = this.Price;
            int newCarPrice = price - (price / 100 * discount);

            this.Price = newCarPrice;
        }
    }
}
