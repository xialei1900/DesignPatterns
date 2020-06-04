namespace Builder
{
    public class ConcreteBuilder:IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartA2");
        }

        public void BuildPartC()
        {
            this._product.Add("PartA3");
        }
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}