using AbstractFactoryPattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;
            client = new Client(new ConcreteFactory1());
            Console.WriteLine("client with concrete factory 1: {0}", client.Run());
            client = new Client(new ConcreteFactory2());
            Console.WriteLine("client with concrete factory 2: {0}", client.Run());
            Console.ReadLine();
        }
    }
}
