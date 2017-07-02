using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Products
{
    class ConcreteProductB2:AbstractProductB
    {
        public override string Interact(AbstractProductA productA)
        {
            return productA.ToString();
        }
    }
}
