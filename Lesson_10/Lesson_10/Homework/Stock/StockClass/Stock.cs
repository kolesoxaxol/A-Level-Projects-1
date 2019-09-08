using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockClass
{
    public static class Stock
    {
        private static int _value = 10;
        private static int _counter = 0;

        private static List<Product> _Products;

        static Stock()
        {
            _Products = new List<Product>();
        }

        public static void AddProduct(Product product)
        {
            if (_counter > _value)
            {
                Console.WriteLine("Склад переполнен.");
            }
            else
            {
                _Products.Add(product);
                _counter++;
            }
        }

        public static List<Product> GetProducts()
        {
            List<Product> productsList = _Products;
            return productsList;
        }

        public static Product СheckProducts(Product product)
        {

            if (DateTime.Now > product.ExpirationDate)
            {
                product.Status = "Подлежит списанию";
                return product;
            }

            return null;
        }
    }
}
