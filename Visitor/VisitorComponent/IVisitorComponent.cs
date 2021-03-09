namespace Visitor
{
    public interface IVisitorComponent
    {
        void Accept(IVisitor visitor);
    }
}