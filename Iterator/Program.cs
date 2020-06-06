using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ConcreteCollection();

            collection.AddItem("Item A");
            collection.AddItem("Item B");
            collection.AddItem("Item C");

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            collection.Reverse();

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
