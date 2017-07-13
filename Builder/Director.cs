namespace BuilderPattern
{
    public class Director
    {
        AbstractBuilder builder = null;
        public Director()
        {

        }
        public Director( AbstractBuilder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
        // Alternative approach
        public void Construct(AbstractBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
