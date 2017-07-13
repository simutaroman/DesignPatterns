using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
        public Product CallFactoryMethod()
        {
            var product = this.FactoryMethod();
            return product;
        }
    }
}
