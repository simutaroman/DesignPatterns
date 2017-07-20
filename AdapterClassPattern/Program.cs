using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClassPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget t = new Adapter();
            t.Query();
            Console.ReadKey();
        }
    }
}
