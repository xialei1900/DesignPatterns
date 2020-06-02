namespace AbstractFactory
{
    //抽象工厂接口声明了一组返回不同抽象产品的方法。
    //这些产品被称为一个系列，并与一个高层次的主题或概念相关。
    //一个系列的产品通常能够相互协作。
    //一个产品系列可能有几个变体，但一个变体的产品与另一个变体的产品不兼容。
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
        IAbstractProductB CreateProductAB();
    }
}