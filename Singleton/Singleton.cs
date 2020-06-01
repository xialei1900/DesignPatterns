using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    // 此Singleton实现称为“双重检查锁定”。
    // 在多线程环境中它是安全的，并为Singleton对象提供了延迟初始化。
    class Singleton
    {
        public string Value { get; set; }
        private Singleton() { }

        private static Singleton _singleton;

        private static readonly object Object = new object();

        public static Singleton GetInstance(string value)
        {
            if (_singleton == null)
            {
                // 现在，假设该程序刚刚启动。
                // 由于还没有Singleton实例，因此多个线程可以同时通过先前的条件并几乎同时到达这一点。
                // 他们中的第一个将获得锁定并将继续进行操作，而其余的将在这里等待。
                lock (Object)
                {
                    // 获取锁的第一个线程达到此条件，进入内部并创建Singleton实例。
                    // 一旦离开锁块，可能一直在等待锁释放的线程可能会进入此部分。
                    // 但是由于Singleton字段已经初始化，因此线程不会创建新对象。
                    if (_singleton == null)
                    {
                        _singleton = new Singleton {Value = value};
                    }
                }
            }

            return _singleton;
        }
    }
}
