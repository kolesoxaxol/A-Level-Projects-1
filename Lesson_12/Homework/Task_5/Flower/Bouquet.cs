using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    public class Bouquet
    {
        private int _price;

        private List<Flowers> _flowers = new ArrayList<Flowers>();

        public int GetPrice()
        {
            foreach (Flowers flower in _flowers)
            {
                _price += flower.Price * flower.Quantity;
            }
            return _price;
        }

        public void AddFlowers(Flowers flower)
        {
            _flowers.Add(flower);
        }

        public List<Flowers> GetFlowers()
        {
            List<Flowers> tempFlowers = _flowers;
            return tempFlowers;
        }

        private class ArrayList<T> : List<Flowers>
        {

        }
    }
}
