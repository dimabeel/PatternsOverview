using System;

namespace Controller
{
    public class ConcreteComponentA : BaseComponent
    {
        public void DoWorkA()
        {
            Console.WriteLine($"{GetType().Name} is doing work A...");
            controller.Handle("A");
        }
    }
}
