using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => { TestSingleton("hello singleton 1"); });
            Thread thread2 = new Thread(() => { TestSingleton("hello singleton 2"); });

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }

        public static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);

            Console.WriteLine($"current thread Id:{Thread.CurrentThread.ManagedThreadId} | {singleton.Value}");
        }
    }
}
