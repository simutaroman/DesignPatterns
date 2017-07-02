using AbstractFactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    class ConcreteFactory2:AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
