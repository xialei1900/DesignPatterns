namespace FactoryMethod
{
    // 具体产品提供产品接口的各种实现。
    public class Product1 : IProduct
    {
        public string DoSomeWork()
        {
            return "ProductOne work done!";
        }
    }
}