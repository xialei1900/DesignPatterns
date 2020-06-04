using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConcreteBuilder();
            var director = new Director();

            director.Builder = builder;

            director.BuildMinimalViableProduct();
            Console.WriteLine($"{builder.GetProduct().ListParts()}");

            director.BuildFullFeaturedProduct();
            Console.WriteLine($"{builder.GetProduct().ListParts()}");

            builder.BuildPartA();
            builder.BuildPartC();
            Console.WriteLine($"{builder.GetProduct().ListParts()}");
            ;
        }
    }
}
