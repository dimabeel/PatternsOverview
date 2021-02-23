using System;

namespace AbstractFactory.Vehicle.Civil
{
    class CivilShip : IShip
    {
        public void Bell()
        {
            Console.WriteLine("Civil ship bell");
        }
    }
}
