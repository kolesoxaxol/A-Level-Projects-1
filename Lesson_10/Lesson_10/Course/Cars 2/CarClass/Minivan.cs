using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    public class Minivan : Car
    {
        
        public int CarCapacity { get; private set; }


        public Minivan(string modele, string color, int carCapacity, int price)
        {
            this.Modele = modele;
            this.Color = color;
            this.CarCapacity = carCapacity;
            this.Price = price;
            this.Type = "Manivan";

            // СКИДКА ПО ЧИСЛУ МЕСЯЦА
            SetDiscount(Convert.ToInt32(DateTime.Now.ToString("MM")) * 2);
        }
    }
}
