using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBuilder builder = new ConcreteBuilder();
            //Director director = new Director(builder);
            //director.Construct();
            
            //Alternative approach. Like it much more.
            Director director = new Director();
            director.Construct(builder);

            Product product = builder.GetResult();
            Console.WriteLine(product.Show());
            Console.ReadLine();
        }
    }
}
