using FactoryMethod.Phones;

namespace FactoryMethod
{
    class IOSPhoneCreator : PhoneCreator
    {
        public override IPhone CreatePhone()
        {
            return new IOSPhone();
        }
    }
}
