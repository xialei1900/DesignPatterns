namespace AbstractFactory
{
    // 具体产品由相应的工厂生产。
    public class ProductA_1:IAbstractProductA
    {
        public string FunctionA()
        {
            return "The result of the ProductA_1.";
        }
    }
}