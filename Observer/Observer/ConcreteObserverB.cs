using System;

namespace Observer
{
    public class ConcreteObserverB:IObserver
    {
        public void Update(IPublisher publisher)
        {
            if ((publisher as Publisher).State >= 4)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}