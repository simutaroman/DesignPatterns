using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern
{
    class Client
    {
        AbstractProductA productA = null;
        AbstractProductB productB = null;

        public Client(AbstractFactory factory)
        {
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }

        public string Run()
        {
            return productB.Interact(productA);
        }
    }
}
