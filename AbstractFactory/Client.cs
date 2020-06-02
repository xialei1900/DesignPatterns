using System;

namespace AbstractFactory
{
    // 客户端只能通过抽象类型处理工厂和产品：AbstractFactory 和 AbstractProduct。
    // 这允许您将任何工厂或产品子类传递给客户机代码，而不会破坏它。
    public class Client
    {
        public void Main()
        {
            ClientCode(new ConcreteFactory1());
            Console.WriteLine("----------------------------------");
            ClientCode(new ConcreteFactory2());
            Console.WriteLine("----------------------------------");
            ClientCode(new ConcreteFactory3());
        }

        //客户端可以与任何具体的工厂类一起工作。
        public void ClientCode(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();
            var productAB = factory.CreateProductAB();

            Console.WriteLine(productA.FunctionA());
            Console.WriteLine(productB.AnotherFunctionB(productA));
            Console.WriteLine(productAB.AnotherFunctionB(productA));
        }
    }
}