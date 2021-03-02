namespace Composite.Leafs
{
    public abstract class LeafComponent : IComponent
    {
        public void Add(IComponent component) { }

        public void Remove(IComponent component) { }

        public bool IsComposite
        {
            get
            {
                return false;
            }
        }

        public abstract void Execute();
    }
}
