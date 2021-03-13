using System;

namespace Controller
{
     public interface IController
    {
        void Handle(string eventType);

        void SetComponentA(ConcreteComponentA componentA);

        void SetComponentB(ConcreteComponentB componentB);

        void SetComponentC(ConcreteComponentC componentC);
    }
}
