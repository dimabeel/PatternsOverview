using System;

namespace AbstractFactory.Vehicle.Millitary
{
    class MillitaryShip : IShip
    {
        public void Bell()
        {
            Console.WriteLine("Millitary ship bell");
        }
    }
}
