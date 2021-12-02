namespace AbstractFactory
{
    //This is a class which implements the AbstractFactory interface(IMobilePhone) operations to create concrete products.
    class Samsung : IMobilePhone            //Concrete Factory
    {
        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }

        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }
    }
}
