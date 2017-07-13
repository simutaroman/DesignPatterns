using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class ConcreteCreator2: Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
