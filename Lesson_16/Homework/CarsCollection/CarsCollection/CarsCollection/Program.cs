using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsLibrary;

namespace CarsCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mazda", "White", 500.00);
            Car car2 = new Car("BMW", "Black", 700);
            Car car3 = new Car("Mercedes", "Silver", 750.00);
            Car car4 = new Car("Lada", "White", 100.00);
            Car car5 = new Car("Opel", "Green", 450.00);

            Cars carsCollection = new Cars(5);

            carsCollection.AddItem(car1);
            carsCollection.AddItem(car2);
            carsCollection.AddItem(car3);
            carsCollection.AddItem(car4);
            carsCollection.AddItem(car5);

            foreach (Car collectedCar in carsCollection)
            {
                Console.WriteLine($"Model: {collectedCar.ModelName}, Color: {collectedCar.Color}, Price: {collectedCar.Price}");
            }

            carsCollection.Reset();

            Console.WriteLine(new string('-', 50));

            foreach (Car collectedCar in carsCollection)
            {
                Console.WriteLine($"Model: {collectedCar.ModelName}, Color: {collectedCar.Color}, Price: {collectedCar.Price}");
            }
        }
    }
}
