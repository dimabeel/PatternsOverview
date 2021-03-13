using System;

namespace Controller
{
    public class ConcreteComponentC : BaseComponent
    {
        public void DoWorkC()
        {
            Console.WriteLine($"{GetType().Name} is doing work C...");
            controller.Handle("C");
        }
    }
}
