using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClassPattern
{
    public class Adaptee
    {
        public string SpecQuery()
        {
            return "Special query";
        }
    }
}
