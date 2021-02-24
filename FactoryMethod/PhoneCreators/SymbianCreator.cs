using FactoryMethod.Phones;

namespace FactoryMethod
{
    class SymbianCreator : PhoneCreator
    {
        public override IPhone CreatePhone()
        {
            return new SymbianPhone();
        }
    }
}
