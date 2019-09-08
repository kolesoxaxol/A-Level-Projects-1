using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    public class Truck : Car
    {
        public int CarryingCapacity { get; private set; }
        public bool Insurance { get; private set; }
        public int Mileage { get; private set; }

        public Truck(string modele, string color, int carryingCapacity, bool insurance, int mileage, int price)
        {
            this.Modele = modele;
            this.Color = color;
            this.CarryingCapacity = carryingCapacity;
            this.Insurance = insurance;
            this.Mileage = mileage;
            this.Price = price;
            this.Type = "Truck";

            SetDiscount(30);
        }

    }
}
