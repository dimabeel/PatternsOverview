using System.Collections.Generic;

namespace Composite.Components
{
    public abstract class CompositeComponent : IComponent
    {
        public CompositeComponent()
        {
            components = new List<IComponent>();
        }

        public abstract void Execute();

        public void Add(IComponent component)
        {
            bool noComponent = components.Contains(component) == false;
            if (noComponent)
            {
                components.Add(component);
            }
        }

        public void Remove(IComponent component)
        {
            component.Remove(component);
        }

        public bool IsComposite
        {
            get
            {
                return true;
            }
        }

        protected IList<IComponent> components;
    }
}
