using System;

namespace AbstractFactory.Vehicle.Civil
{
    class CivilHelicopter : IHelicopter
    {
        public void Respond()
        {
            Console.WriteLine("Civil helicopter is here");
        }
    }
}
