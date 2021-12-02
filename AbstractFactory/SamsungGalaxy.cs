namespace AbstractFactory
{
//This defines a product object to be created by the corresponding concrete factory(Samsung) also implements the AbstractProduct interface(ISmartPhone).
    class SamsungGalaxy : ISmartPhone               //Product
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}
