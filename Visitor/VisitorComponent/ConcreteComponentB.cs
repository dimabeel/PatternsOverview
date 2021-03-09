using System;

namespace Visitor
{
    public class ConcreteComponentB : IVisitorComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void ShowYourName()
        {
            Console.WriteLine($"My name is {this.GetType().Name} component!");
        }
    }
}
