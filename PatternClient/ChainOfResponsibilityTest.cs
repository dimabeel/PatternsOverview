using System;
using ChainOfResponsibility;
using System.Collections.Generic;

namespace PatternClient
{
    public class ChainOfResponsibilityTest
    {
        public void Work()
        {
            var vehicles = new List<IVehicle>
            {
                new Truck(),
                new Car(),
                new SUV(),
                new SportCar(),
                new Bicycle(),
            };

            var sportCarHandler = new SportCarHandler();
            var suvHandler = new SUVHandler();
            var carHandler = new CarHandler();
            var TruckHandler = new TruckHandler();
            sportCarHandler.SetNext(suvHandler).SetNext(carHandler)
                .SetNext(TruckHandler);

            foreach(var vehicle in vehicles)
            {
                var result = sportCarHandler.Handle(vehicle);
                if(result == null)
                {
                    Console.Write($"{vehicle.GetType().Name} can't be filled by fuel");
                }
            }
        }
    }
}