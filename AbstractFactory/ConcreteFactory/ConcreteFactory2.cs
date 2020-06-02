namespace AbstractFactory
{
    // 每个具体实现的工厂都有相应的产品变体。
    public class ConcreteFactory2:IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA_2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB_2();
        }

        public IAbstractProductB CreateProductAB()
        {
            return new ProductAB();
        }
    }
}