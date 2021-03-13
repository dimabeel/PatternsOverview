using System;
using Controller;

namespace PatternClient
{
    public class ControllerTest
    {
        public void Work()
        {
            var componentA = new ConcreteComponentA();
            var componentB = new ConcreteComponentB();
            var componentC = new ConcreteComponentC();
            IController controller = new Controller.Controller();
            controller.SetComponentA(componentA);
            controller.SetComponentB(componentB);
            controller.SetComponentC(componentC);

            componentA.DoWorkA();
            Console.WriteLine();
            componentB.DoWorkB();
            Console.WriteLine();
            componentC.DoWorkC();
            Console.WriteLine();
        }
    }
}