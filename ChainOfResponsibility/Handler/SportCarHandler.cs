using System;

namespace ChainOfResponsibility
{
    public class SportCarHandler : BaseVehicleHandler
    {
        public override object Handle(object request)
        {
            if (request is SportCar s)
            {
                Console.WriteLine($"{s.GetType().Name} uses 95th petrol");
                return s;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}