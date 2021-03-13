using System;

namespace Controller
{
    public class ConcreteComponentB : BaseComponent
    {
        public void DoWorkB()
        {
            Console.WriteLine($"{GetType().Name} is doing work B...");
            controller.Handle("B");
        }
    }
}
