namespace AbstractFactory
{
    public class ConcreteFactory3:IAbstractFactory
    {
        // 每个具体实现的工厂都有相应的产品变体。
        public IAbstractProductA CreateProductA()
        {
            return new ProductA_1();
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