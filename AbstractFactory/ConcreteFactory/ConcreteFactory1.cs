namespace AbstractFactory
{
    //具体实现工厂生产属于单一变体的一系列产品。
    //工厂保证生产出的产品兼容。
    //注意具体工厂方法的签名返回一个抽象产品，而在方法内部则实例化一个具体产品。
    public class ConcreteFactory1:IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA_1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB_1();
        }

        public IAbstractProductB CreateProductAB()
        {
            return new ProductAB();
        }
    }
}