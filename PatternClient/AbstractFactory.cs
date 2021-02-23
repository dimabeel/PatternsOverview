using System;
using System.Collections.Generic;
using System.Linq;
using AbstractFactory;

namespace PatternClient
{
    class AbstractFactoryTest
    {
        public void Work()
        {
            // For example - we have already known factory types. We can
            // read it from configuration or another source.
            var factoryTypes = new List<VehicleFactory.VehicleType>()
            { 
                VehicleFactory.VehicleType.Civil,
                VehicleFactory.VehicleType.Millitary
            };

            foreach(var factoryType in factoryTypes)
            {
                var factory = VehicleFactory.GetFactory(factoryType);
                IShip ship = factory.CreateShip();
                ICar car = factory.CreateCar();
                IHelicopter helicopter = factory.CreateHelicopter();

                ship.Bell();
                car.Horn();
                helicopter.Respond();
                Console.WriteLine("");
            }
        }
        
    }
}
