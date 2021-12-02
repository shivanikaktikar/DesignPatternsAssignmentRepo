namespace AbstractFactory
{
//This defines a product object to be created by the corresponding concrete factory(Nokia) also implements the AbstractProduct interface(ISmartPhone).
    class NokiaPixel : ISmartPhone              //Product
    {
        public string GetModelDetails()
        {
            return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}
