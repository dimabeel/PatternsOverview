using Composite;
using Composite.Components;
using Composite.Leafs;

namespace PatternClient
{
    public class CompositeTest
    {
        public void Work()
        {
            IComponent mainComponent = new ConcreteCompositeA();
            mainComponent.Add(new ConcreteLeafA());
            mainComponent.Add(new ConcreteLeafA());

            IComponent anotherComposite = new ConcreteCompositeB();
            anotherComposite.Add(new ConcreteLeafB());
            anotherComposite.Add(new ConcreteLeafB());
            anotherComposite.Add(new ConcreteLeafB());

            mainComponent.Add(anotherComposite);
            mainComponent.Execute();
        }
    }
}
