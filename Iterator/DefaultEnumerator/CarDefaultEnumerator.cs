using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator.DefaultEnumerator
{
    public class CarDefaultEnumerator : IEnumerator
    {
        public CarDefaultEnumerator(ICar[] iterator)
        {
            carForIterator = iterator;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                return carForIterator[position];
            }
        }

        public bool MoveNext()
        {
            if (position < carForIterator.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        int position = -1;
        ICar[] carForIterator;
    }
}
