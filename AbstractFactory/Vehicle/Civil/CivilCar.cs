using System;

namespace AbstractFactory.Vehicle.Civil
{
    class CivilCar : ICar
    {
        public void Horn()
        {
            Console.WriteLine("Civil car beep beep");
        }
    }
}
