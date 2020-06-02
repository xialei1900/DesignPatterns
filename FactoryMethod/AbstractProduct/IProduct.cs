using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    // 产品接口声明所有具体产品必须实现的操作。
    public interface IProduct
    {
        string DoSomeWork();
    }
}
