using System;

namespace ChainOfResponsibility
{
    public class SUVHandler : BaseVehicleHandler
    {
        public override object Handle(object request)
        {
            if (request is SUV s)
            {
                Console.WriteLine($"{s.GetType().Name} uses diesel");
                return s;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}