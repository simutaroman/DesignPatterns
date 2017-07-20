using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Target t = new Adapter();
            t.Query();
            Console.ReadKey();
        }
    }
}
