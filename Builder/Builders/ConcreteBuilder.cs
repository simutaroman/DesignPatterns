namespace BuilderPattern
{
    public class ConcreteBuilder:AbstractBuilder
    {
        public ConcreteBuilder()
        {
            product = new Product();
        }
        public override void BuildPartA()
        {
            product.Add("Part A");
        }
        public override void BuildPartB()
        {
            product.Add("Part B");
        }
    }
}
