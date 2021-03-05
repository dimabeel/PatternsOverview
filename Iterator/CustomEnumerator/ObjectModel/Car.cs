using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.CustomEnumerator
{
    public interface ICar
    {
        string Name { get; set; }
        int YearOfProduction { get; set; }
    }

    public class Car : ICar
    {
        public string Name { get; set; }

        public int YearOfProduction { get; set; }
    }
}
