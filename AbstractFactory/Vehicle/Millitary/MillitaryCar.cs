using System;

namespace AbstractFactory.Vehicle.Millitary
{
    class MillitaryCar : ICar
    {
        public void Horn()
        {
            Console.WriteLine("Millitary car beep beep");
        }
    }
}
