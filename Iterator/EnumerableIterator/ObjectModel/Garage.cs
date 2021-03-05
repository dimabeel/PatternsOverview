using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.EnumerableIterator
{
    public interface IGarage
    {
        string Name { get; set; }

        ICar[] Cars { get; }
    }

    public class Garage : IGarage, IGarageNode
    {
        public Garage(ICar[] cars)
        {
            this.cars = cars;
        }

        public override string ToString()
        {
            return $"Garage: {Name}";
        }

        public string Name { get; set; }

        public ICar[] Cars
        {
            get
            {
                return cars;
            }
        }

        public bool HasChildren()
        {
            return cars.Length > 0;
        }

        public IEnumerable<IGarageNode> GetChildren()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                yield return cars[i] as IGarageNode;
            }
        }

        public int Count
        {
            get
            {
                return cars.Length;
            }
        }

        ICar[] cars;
    }
}
