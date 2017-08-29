using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component leaf1 = new Leaf("leaf1");
            Component leaf2 = new Leaf("leaf2");
            Component branch1 = new Composite("branch1");
            Component branch2 = new Composite("branch2");
            Component root = new Composite("root");

            branch1.Add(leaf1);
            root.Add(branch1);
            branch2.Add(leaf2);
            root.Add(branch2);
            branch2.Add(new Leaf("leaf3"));
            root.Operation();
            Console.WriteLine();
            Console.WriteLine("Removing...");

            root.GetChild(1).Remove(leaf2);
            root.Operation();
        }
    }
}
