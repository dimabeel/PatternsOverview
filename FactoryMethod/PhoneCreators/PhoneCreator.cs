using FactoryMethod.Phones;

namespace FactoryMethod
{
    public abstract class PhoneCreator
    {
        public abstract IPhone CreatePhone();
    }
}
