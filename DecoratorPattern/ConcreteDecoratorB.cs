using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ConcreteDecoratorB:Decorator
    {
        public void AddBehaviour()
        {
            Console.WriteLine("Concrete decorator B added behaviour");
        }
        public override void Operation()
        {
            base.Operation();
            AddBehaviour();
        }
    }
}
