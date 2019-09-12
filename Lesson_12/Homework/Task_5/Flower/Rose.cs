using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    public class Rose : Flowers
    {
        private static string _name = "Rose";

        public static int RosePrice { get; set; } = 50;

        //private int _totalRosePrice;

        public Rose(int quantity) : base(_name, quantity)
        {
            Price = RosePrice;
        }

        // --- Вначале подсчитывал цену и количество цветов одного типа в классе с определённым цветком, но позже подумал, что цветок не может иметь характеристику количества и конечной цены с учётом количества в рамках задачи.
        // Это относится к самому букету, по-этому логику подсчёта перенёс туда.

        //public override int Price
        //{
        //    get
        //    {
        //        return _totalRosePrice;
        //    }
        //    set { _totalRosePrice = value * Quantity; }
        //}
    }
}
