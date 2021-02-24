using System.Collections.Generic;
using FactoryMethod;
using FactoryMethod.Phones;

namespace PatternClient
{
    class FactoryMethodTest
    {
        public void Work()
        {
            // For example - we have already known factory types. We can
            // read it from configuration or another source.
            var phoneTypes = new List<CreatorGetter.PhoneType>
            {
                CreatorGetter.PhoneType.Symbian,
                CreatorGetter.PhoneType.Android,
                CreatorGetter.PhoneType.IOS
            };

            foreach(var phoneType in phoneTypes)
            {
                PhoneCreator creator = CreatorGetter.GetCreator(phoneType);
                IPhone phone = creator.CreatePhone();
                phone.Notify();
            }          
        }
    }
}
