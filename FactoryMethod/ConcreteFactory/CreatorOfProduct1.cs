namespace FactoryMethod
{
    // 具体的创建者会覆盖工厂方法，以更改最终产品的类型。
    public class CreatorOfProduct1 : Creator
    {
        public override IProduct CreateProduct()
        {
            // 注意，即使具体的产品实际上是从方法中返回的，方法的签名仍然使用抽象产品类型。
            // 这样，Creator可以独立于具体的产品类别。
            return new Product1();
        }
    }
}