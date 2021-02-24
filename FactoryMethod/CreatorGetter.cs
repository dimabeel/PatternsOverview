namespace FactoryMethod
{
    public static class CreatorGetter
    {
        public enum PhoneType
        {
            Android,
            Symbian,
            IOS
        }

        public static PhoneCreator GetCreator(PhoneType phoneType)
        {
            switch(phoneType)
            {
                default:
                case PhoneType.Android:
                    return new AndroidCreator();

                case PhoneType.IOS:
                    return new IOSPhoneCreator();

                case PhoneType.Symbian:
                    return new SymbianCreator();
            }
        }
    }
}
