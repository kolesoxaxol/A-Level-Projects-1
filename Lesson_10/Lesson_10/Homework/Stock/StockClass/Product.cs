using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StockClass
{
    public class Product : BaseProduct
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public DateTime DeliveryDate { get; private set; }
        public string Status { get; protected internal set; } = "Годен";

        public Product(string name, int price, string deliveryDate, int shelflife):base(shelflife)
        {
            DateTime _deliveryDate = Convert.ToDateTime(deliveryDate);

            this.Name = name;
            this.Price = price;
            this.DeliveryDate = _deliveryDate;


            GetExpirationDate(_deliveryDate, shelflife);
        }
    }
}
