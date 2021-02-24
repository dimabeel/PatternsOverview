using FactoryMethod.Phones;

namespace FactoryMethod
{
    class AndroidCreator : PhoneCreator
    {
        public override IPhone CreatePhone()
        {
            return new AndroidPhone();
        }
    }
}
