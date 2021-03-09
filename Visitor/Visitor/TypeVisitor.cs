using System;

namespace Visitor
{
    public class TypeVisitor : IVisitor
    {
        public void Visit(ConcreteComponentA s1Component)
        {
            Console.WriteLine($"Hello, I'm {this.GetType().Name} and now "
                + $"I'm working with {s1Component.GetType().Name}.");
            s1Component.ShowYourself();
        }

        public void Visit(ConcreteComponentB s2Component)
        {
            Console.WriteLine($"Hi, I'm {this.GetType().Name}. I'm working" +
                $" with {s2Component.GetType().Name}.");
            s2Component.ShowYourName();
        }
    }
}