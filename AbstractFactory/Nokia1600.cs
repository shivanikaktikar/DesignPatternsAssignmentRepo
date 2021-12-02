namespace AbstractFactory
{
    //This defines a product object to be created by the corresponding concrete factory(Nokia) also implements the AbstractProduct interface(INormalPhone).
    class Nokia1600 : INormalPhone              //Product
    {
        public string GetModelDetails()
        {
            return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
