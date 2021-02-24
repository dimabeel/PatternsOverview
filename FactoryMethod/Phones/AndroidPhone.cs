using System;

namespace FactoryMethod.Phones
{
    class AndroidPhone : IPhone
    {
        public void Notify()
        {
            Console.WriteLine("I'm using Android!");
        }
    }
}
