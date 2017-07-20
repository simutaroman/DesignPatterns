using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClassPattern
{
    public class Adapter : Adaptee, ITarget
    {
        public void Query()
        {
            Console.WriteLine("Calling special query from Adaptee: {0}", SpecQuery());
        }
    }
}
