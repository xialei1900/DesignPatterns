namespace AbstractFactory
{
    //不明白这种实现是否正确，有没有破坏某种原则
    public class ProductAB:IAbstractProductA,IAbstractProductB
    {
        public string FunctionA()
        {
            return "The result of the ProductAB.";
        }

        public string FunctionB()
        {
            return "The result of the ProductAB.";
        }

        public string AnotherFunctionB(IAbstractProductA productA)
        {
            var result = productA.FunctionA();

            return $"The result of the AB collaborating with the ({result})";
        }
    }
}