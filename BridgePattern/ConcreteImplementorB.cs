using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class ConcreteImplementorB : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorB.OperationImp()");
        }
    }
}
