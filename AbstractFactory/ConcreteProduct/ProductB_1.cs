namespace AbstractFactory
{
    public class ProductB_1:IAbstractProductB
    {
        public string FunctionB()
        {
            return "The result of the product B1.";
        }

        //变型产品B1只能与变型产品A1正常工作。(不太懂...)
        //然而，它接受任何AbstractProductA实例作为参数。
        public string AnotherFunctionB(IAbstractProductA productA)
        {
            var result = productA.FunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }
    }
}