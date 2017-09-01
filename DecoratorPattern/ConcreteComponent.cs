using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Component operation");
        }
    }
}
