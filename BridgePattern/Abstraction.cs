using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    abstract class Abstraction
    {
        protected Implementor imp = null;
        public Abstraction( Implementor imp)
        {
            this.imp = imp;
        }
        public virtual void Operation()
        {
            Console.WriteLine("Calling implementor operation from abstraction operation");
            imp.OperationImp();
        }
    }
}
