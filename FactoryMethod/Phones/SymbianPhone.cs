using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Phones
{
    class SymbianPhone : IPhone
    {
        public void Notify()
        {
            Console.WriteLine("I'm using Symbian!");
        }
    }
}
