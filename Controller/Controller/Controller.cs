using System;

namespace Controller
{
    public class Controller : IController
    {
        public void Handle(string eventType)
        {
            switch(eventType)
            {
                case "A":
                concreteComponentB.DoWorkB();
                break;

                case "B":
                concreteComponentC.DoWorkC();
                break;

                case "C":
                Console.WriteLine("All work has already done");
                break;
            }
        }

        public void SetComponentA(ConcreteComponentA componentA)
        {
            this.concreteComponentA = componentA;
            componentA.SetController(this);
        }

        public void SetComponentB(ConcreteComponentB componentB)
        {
            this.concreteComponentB = componentB;
            componentB.SetController(this);
        }

        public void SetComponentC(ConcreteComponentC componentC)
        {
            this.concreteComponentC = componentC;
            componentC.SetController(this);
        }

        ConcreteComponentA concreteComponentA;
        ConcreteComponentB concreteComponentB;
        ConcreteComponentC concreteComponentC;
    }
}
