namespace AbstractFactory       
{

//This is an interface for operations which is used to create abstract product.
interface IMobilePhone          //Abstract Factory
    {  
        ISmartPhone GetSmartPhone();  
        INormalPhone GetNormalPhone();  
    } 
}