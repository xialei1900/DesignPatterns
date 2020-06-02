using System;

namespace FactoryMethod
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new CreatorOfProductOne());

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new CreatorOfProductTwo());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine($"Client: I'm not aware of the creator's class,but it still works.\n {creator.CoreWork()}");
        }
    }
}