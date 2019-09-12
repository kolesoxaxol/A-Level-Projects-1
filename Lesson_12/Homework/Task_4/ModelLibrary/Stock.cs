using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public static class Stock
    {
        private static List<Product> stock = new List<Product>();

        public static void AddToStock(Product product, int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                stock.Add(product);
            }
        }

        public static List<Product> GetProductsFromStock()
        {
            return stock;
        }
    }
}
