using System;

namespace FactoryMethod
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new CreatorOfProduct1());

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new CreatorOfProduct2());
        }

        // 客户端代码虽然通过其基本接口与具体创建者的实例一起工作。
        // 只要客户端继续通过基本接口与创建者合作，就可以将其传递给任何创建者的子类。
        public void ClientCode(Creator creator)
        {
            Console.WriteLine($"Client: I'm not aware of the creator's class,but it still works.\n {creator.CoreWork()}");
        }
    }
}