namespace FactoryMethod
{
    // Creator类声明了工厂方法，该方法应该返回Product类的对象。 创建者的子类通常提供此方法的实现。
    // 请注意，创建者可能还会提供一些工厂方法的默认实现。
    public abstract class Creator
    {
        public abstract IProduct CreateProduct();

        // 另请注意，尽管它的名字叫创造者，但它的主要责任不是创造产品。
        // 通常，它包含一些依赖于Product对象的核心业务逻辑，这些逻辑是由factory方法返回的。
        // 子类可以通过覆盖工厂方法并从中返回不同类型的产品来间接更改该业务逻辑。
        public string CoreWork()
        {
            var product = CreateProduct();

            var result = "Creator: The same creator's code has just worked with "
                         + product.DoSomeWork();

            return result;
        }
    }
}