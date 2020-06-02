namespace AbstractFactory
{
    // 这是另一个产品的基本接口。
    // 所有的产品都是相互作用的，但只有在同一具体变体的产品之间才能进行适当的相互作用。
    public interface IAbstractProductB
    {
        string FunctionB();

        //但它也可以与ProductA协作。
        //抽象工厂确保它创建的所有产品都是相同的变体，因此是兼容的。
        string AnotherFunctionB(IAbstractProductA productA);
    }
}