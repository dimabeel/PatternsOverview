using System;

namespace ChainOfResponsibility
{
    public class TruckHandler : BaseVehicleHandler
    {
        public override object Handle(object request)
        {
            if (request is Truck s)
            {
                Console.WriteLine($"{s.GetType().Name} uses arctic diesel");
                return s;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}