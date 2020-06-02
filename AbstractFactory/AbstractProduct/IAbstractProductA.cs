namespace AbstractFactory
{
    //产品系列的每个不同产品都应该基于同一个接口。全部产品的变体必须实现此接口。
    public interface IAbstractProductA
    {
        string FunctionA();
    }
}