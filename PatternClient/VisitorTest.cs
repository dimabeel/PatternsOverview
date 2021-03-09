using System.Collections.Generic;
using Visitor;

namespace PatternClient
{
    public class VisitorTest
    {
        public void Work()
        {
            var components = new List<IVisitorComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB(),
            };

            IVisitor visitor = new TypeVisitor();

            IClient client = new Client(components, visitor);
            client.RunVisitors();
        }
    }
}