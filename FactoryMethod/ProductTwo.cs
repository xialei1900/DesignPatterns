namespace FactoryMethod
{
    // 具体产品提供产品接口的各种实现。
    public class ProductTwo:IProduct
    {
        public string DoSomeWork()
        {
            return "ProductTwo work done!";
        }
    }
}