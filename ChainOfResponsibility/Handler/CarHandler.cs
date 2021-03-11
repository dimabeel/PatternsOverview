using System;

namespace ChainOfResponsibility
{
    public class CarHandler : BaseVehicleHandler
    {
        public override object Handle(object request)
        {
            if (request is Car s)
            {
                Console.WriteLine($"{s.GetType().Name} uses 92 petrol");
                return s;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}