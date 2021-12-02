namespace AbstractFactory
{
//This defines a product object to be created by the corresponding concrete factory(Samsung) also implements the AbstractProduct interface(INormalPhone).
    class SamsungGuru : INormalPhone            //Product
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
