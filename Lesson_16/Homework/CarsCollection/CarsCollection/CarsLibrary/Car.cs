using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibrary
{
    public class Car
    {
        public string ModelName { get; private set; }
        public string Color { get; private set; }
        public double Price { get; private set; }

        public Car(string modelName, string color, double price)
        {
            ModelName = modelName;
            Color = color;
            Price = price;
        }

        
    }
}
