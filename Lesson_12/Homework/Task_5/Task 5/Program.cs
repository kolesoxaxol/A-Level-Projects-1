using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flower_Shop;

namespace Task_5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Rose.RosePrice = 70; // цена розы изменилась с 50 на 70 руб.

            Flowers[] newBouquet = new Flowers[3]
            {
                new Rose(5),
                new Tulip(3),
                new Clove(2)
            };

            Bouquet bouquet = new Bouquet();
            foreach (var flowers in newBouquet)
            {
                bouquet.AddFlowers(flowers);
            }

            int totalPrice = bouquet.GetPrice();

            Console.WriteLine($"Цена букета: {totalPrice} руб.");

            var flowersBouquet = bouquet.GetFlowers(); // получаем цветы в букете по требованию

            Console.ReadLine();
        }
    }
}
