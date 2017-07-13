using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // todo: this code needs to be refactored :)
            Creator creator = new ConcreteCreator();
            Product p1 = creator.FactoryMethod();
            Product p2 = creator.CallFactoryMethod();
            Console.WriteLine("p1 = {0}, p2 = {1}", p1.GetHashCode(), p2.GetHashCode());

            creator = new ConcreteCreator2();
            p1 = creator.FactoryMethod();
            p2 = creator.CallFactoryMethod();
            Console.WriteLine("p1 = {0}, p2 = {1}", p1.GetHashCode(), p2.GetHashCode());

            Console.ReadLine();
        }

    }
}
