using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance();
            instance1.InstanceData = "instance1";
            Singleton instance2 = Singleton.Instance();
            instance2.InstanceData = "instance2";
            Console.WriteLine("Is references equal?: {0}", ReferenceEquals(instance1, instance2));
            Console.WriteLine("Hash1: {0}, Hash2: {1}", instance1.GetHashCode(), instance2.GetHashCode());
            Console.WriteLine("Data1: {0}, Data2: {1}", instance1.InstanceData, instance2.InstanceData);
            Console.ReadLine();
        }
    }
}
