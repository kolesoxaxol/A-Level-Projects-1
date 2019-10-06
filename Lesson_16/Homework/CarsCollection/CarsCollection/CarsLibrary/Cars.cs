using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarsLibrary
{
    public class Cars : IEnumerable, IEnumerator
    {
        private Car[] _carsCollection = null;
        private int _index = 0;

        public Cars(int collectionSize)
        {
            _carsCollection = new Car[collectionSize];
        }

        public void AddItem(Car car)
        {
            _carsCollection[_index] = car;
            _index++;
        }

        private int _position = -1;

        public bool MoveNext()
        {
            if (_position < _carsCollection.Length - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }

        public object Current
        {
            get
            {
                return _carsCollection[_position];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }

        // Yield
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _carsCollection.Length; i++)
            {
                yield return _carsCollection[i];
            }
        }
    }
}
