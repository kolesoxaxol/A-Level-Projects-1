using System;
using System.Dynamic;

namespace StockClass
{
    public class BaseProduct
    {
        public int ShelfLife { get; private set; }
        public DateTime ExpirationDate { get; private set; }

        protected BaseProduct(int shelflife)
        {
            this.ShelfLife = shelflife;
        }

        protected void GetExpirationDate(DateTime _deliveryDate, int shelflife)
        {
            DateTime expirationDate = _deliveryDate.AddDays(shelflife);
            ExpirationDate = expirationDate;
        }
    }
}