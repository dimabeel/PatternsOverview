using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.EnumerableIterator
{
    public interface ICar
    {
        string Name { get; set; }

        int YearOfProduction { get; set; }
    }

    public class Car : ICar, IGarageNode
    {
        public string Name { get; set; }

        public int YearOfProduction { get; set; }

        public override string ToString()
        {
            return $"Car: {Name}, {YearOfProduction}";
        }

        public bool HasChildren()
        {
            return Count > 0;
        }

        public IEnumerable<IGarageNode> GetChildren()
        {
            return null;
        }

        public int Count
        {
            get
            {
                return 0;
            }
        }
    }
}
