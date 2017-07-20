using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterObjectPattern
{
    public class Adapter : Target
    {
        private Adaptee adapty = new Adaptee();
        public override void Query()
        {
            Console.WriteLine("Calling special query from Adaptee: {0}", adapty.SpecQuery());
        }
    }
}
