using System;

namespace Observer
{
    public class ConcreteObserverA:IObserver
    {
        public void Update(IPublisher publisher)
        {
            if ((publisher as Publisher).State <= 6)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}