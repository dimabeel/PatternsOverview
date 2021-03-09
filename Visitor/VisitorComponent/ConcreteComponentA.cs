using System;

namespace Visitor
{
    public class ConcreteComponentA : IVisitorComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void ShowYourself()
        {
            Console.WriteLine($"I'm {this.GetType().Name} component!");
        }
    }
}