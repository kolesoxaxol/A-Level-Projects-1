using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    public class Tulip : Flowers
    {
        private static string _name = "Tulip";

        public static int TulipPrice { get; set; } = 15;

        //private int _totalTulipsPrice;

        public Tulip(int quantity) : base(_name, quantity)
        {
            Price = TulipPrice;
        }

        // --- Вначале подсчитывал цену и количество цветов одного типа в классе с определённым цветком, но позже подумал, что цветок не может иметь характеристику количества и конечной цены с учётом количества в рамках задачи.
        // Это относится к самому букету, по-этому логику подсчёта перенёс туда.

        //public override int Price
        //{
        //    get
        //    {
        //        return _totalTulipsPrice;
        //    }
        //    set { _totalTulipsPrice = value * Quantity; }
        //}
    }
}
