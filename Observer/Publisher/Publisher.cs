using System;
using System.Collections.Generic;

namespace Observer
{
    public class Publisher:IPublisher
    {
        // 为了简单起见，对象的状态（对所有订阅者都是必需的）存储在这个变量中。
        public int State { get; set; } = -0;

        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new Random().Next(0,10);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}