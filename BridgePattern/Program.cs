using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Implementor concreteImplementor = new ConcreteImplementorA();
            //Implementor concreteImplementor = new ConcreteImplementorB();
            Abstraction refinedAbstraction = new RefinedAbstraction(concreteImplementor);
            refinedAbstraction.Operation();
            Console.ReadKey();

        }
    }
}
