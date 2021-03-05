using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator.DefaultEnumerator
{
    public class Garage : IEnumerable, IGarage
    {
        public Garage(ICar[] cars)
        {
            this.cars = cars;
        }

        public IEnumerator GetEnumerator()
        {
            var defaultEnumerator = new CarDefaultEnumerator(cars);
            return defaultEnumerator;
        }

        public ICar[] Cars
        {
            get
            {
                return cars;
            }
        }

        ICar[] cars;
    }
}
