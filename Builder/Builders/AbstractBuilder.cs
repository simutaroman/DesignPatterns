namespace BuilderPattern
{
    public abstract class AbstractBuilder
    {
        protected Product product = null;
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public Product GetResult()
        {
            return product;
        }
    }
}
