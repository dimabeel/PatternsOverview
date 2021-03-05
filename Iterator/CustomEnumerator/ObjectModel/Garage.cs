using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.CustomEnumerator
{
    public interface IGarage : IIterableCollection<ICar>
    {
        string Name { get; set; }
    }

    public class Garage : IGarage
    {
        public Garage(ICar[] cars)
        {
            this.cars = cars;
        }

        public IIterator<ICar> CreateIterator()
        {
            return new ObjectIterator<ICar>(cars);
        }

        public string Name { get; set; }

        ICar[] cars;
    }
}
