using System;

namespace AbstractFactory.Vehicle.Millitary
{
    class MillitaryHelicopter : IHelicopter
    {
        public void Respond()
        {
            Console.WriteLine("Millitary helicopter is here");
        }
    }
}
