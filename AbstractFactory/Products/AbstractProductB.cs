using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Products
{
    abstract class AbstractProductB
    {
        public abstract string Interact(AbstractProductA productA);
    }
}
