using System;

namespace FactoryMethod.Phones
{
    class IOSPhone : IPhone
    {
        public void Notify()
        {
            Console.WriteLine("I'm using iOS!");
        }
    }
}
