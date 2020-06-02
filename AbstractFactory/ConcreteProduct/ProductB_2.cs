namespace AbstractFactory
{
    public class ProductB_2:IAbstractProductB
    {
        public string FunctionB()
        {
            return "The result of the product B2.";
        }

        //变型产品B2只能与变型产品A2一起正常工作。
        //然而，它接受任何AbstractProductA实例作为参数。
        public string AnotherFunctionB(IAbstractProductA productA)
        {
            var result = productA.FunctionA();

            return $"The result of the B2 collaborating with the ({result})";
        }
    }
}