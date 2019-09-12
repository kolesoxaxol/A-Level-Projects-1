using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    public class Clove : Flowers
    {
        private static string _name = "Clove";

        public static int ClovePrice { get; set; } = 20;

        //private int _totalCloversPrice;

        public Clove(int quantity) : base(_name, quantity)
        {
            Price = ClovePrice;
        }

        // --- Вначале подсчитывал цену и количество цветов одного типа в классе с определённым цветком, но позже подумал, что цветок не может иметь характеристику количества и конечной цены с учётом количества в рамках задачи.
        // Это относится к самому букету, по-этому логику подсчёта перенёс туда.

        //public override int Price
        //{
        //    get
        //    {
        //        return _totalCloversPrice;
        //    }
        //    set { _totalCloversPrice = value * ClovePrice; }
        //}
    }
}
