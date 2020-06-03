using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher();

            var observerA = new ConcreteObserverA();
            var observerB = new ConcreteObserverB();

            publisher.AddObserver(observerA);
            publisher.AddObserver(observerB);

            publisher.SomeBusinessLogic();
            publisher.SomeBusinessLogic();

            publisher.RemoveObserver(observerA);
            publisher.RemoveObserver(observerB);

            publisher.SomeBusinessLogic();
        }
    }
}
