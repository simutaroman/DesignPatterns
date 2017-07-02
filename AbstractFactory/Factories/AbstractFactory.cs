using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Factories
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
