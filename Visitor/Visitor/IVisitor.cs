namespace Visitor
{
    public interface IVisitor
    {
        void Visit(ConcreteComponentA s1Component);

        void Visit(ConcreteComponentB s2Component);
    }
}