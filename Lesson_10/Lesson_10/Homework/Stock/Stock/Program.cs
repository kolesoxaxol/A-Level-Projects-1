using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using StockClass;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] productsFile = File.ReadAllLines("Products.txt");


           foreach (string product in productsFile)
           {
               string name = product.Split(';')[0];
               int price = Convert.ToInt32(product.Split(';')[1]);
               string deliverydate = product.Split(';')[2];
               int shelftime = Convert.ToInt32(product.Split(';')[3]);

               Product newProduct = new Product(name, price, deliverydate, shelftime);
               Stock.AddProduct(newProduct);
            }
           
            List<Product> products = Stock.GetProducts();

            foreach (Product product in products)
            {
                Console.WriteLine($"Наименование: {product.Name}, Цена: {product.Price} руб., Дата поставки: {product.DeliveryDate}, Дата списания: {product.ExpirationDate}");
            }

            Console.WriteLine(new string('-', 100));

            foreach (Product product in products)
            {
                Product decommissionedProduct = Stock.СheckProducts(product);
                if (decommissionedProduct != null)
                {
                    Console.WriteLine($"Наименование: {product.Name}, Статус: {product.Status}");
                }
            }

            Console.ReadKey();
        }
    }
}
