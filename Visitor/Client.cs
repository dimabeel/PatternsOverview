using System.Collections.Generic;

namespace Visitor
{
    public class Client : IClient
    {
        public Client(ICollection<IVisitorComponent> components,
            IVisitor visitor)
        {
            this.components = components;
            this.visitor = visitor;
        }

        public void RunVisitors()
        {
            foreach(var component in components)
            {
                component.Accept(visitor);
            }
        }

        ICollection<IVisitorComponent> components;
        IVisitor visitor;
    }
}