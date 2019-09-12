using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Furniture_1");
            Product furniture1 = new Furniture("Sofa", "Wooden", "IKEA", "White", 6000.00, true);
            Stock.AddToStock(furniture1, 10);


            Console.WriteLine("Create Furniture_2");
            Product furniture2 = new Furniture("Armchair", "Iron", "IKEA", "Black", 15000.00, true);
            Console.WriteLine("Try to Set Discount for Furniture_2");
            furniture2.SetDiscount(20);
            Stock.AddToStock(furniture2, 15);

            Console.WriteLine("");
            
            Console.WriteLine("Create Raw Material_1");
            RawMaterial.Size size = new RawMaterial.Size { height = 10, width = 20 };
            Product rawmaterial1 = new RawMaterial("Nails", "Wooden", size, 400.00);
            Stock.AddToStock(rawmaterial1, 20);

            Console.WriteLine("Create Raw Material_2 ");
            Product rawmaterial2 = new RawMaterial("Dye", "Acrylic", size, 250.00);

            Console.WriteLine("Try to Set Discount for Material_2");
            rawmaterial2.SetDiscount(20);
            Stock.AddToStock(rawmaterial2, 5);

            Console.WriteLine("");


            Console.WriteLine("Get All Products");
            var stockList = Stock.GetProductsFromStock();

            Console.WriteLine("Prepare to Sale");
            foreach (var product in stockList)
            {
                product.Sell();
            }

            Console.ReadLine();

        }
    }
}
