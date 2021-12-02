namespace AbstractFactory
{
    //This is a class which implements the AbstractFactory interface(IMobilePhone) operations to create concrete products.
    class Nokia : IMobilePhone              //Concrete Factory
    {
        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }

        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }
    }
}
