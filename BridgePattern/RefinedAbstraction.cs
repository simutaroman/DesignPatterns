using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class RefinedAbstraction:Abstraction
    {
        public RefinedAbstraction(Implementor imp):base (imp)
        {

        }

        public override void Operation()
        {
            Console.WriteLine("calling base abstraction operation from refined abstraction");
            base.Operation();
        }
    }
}
