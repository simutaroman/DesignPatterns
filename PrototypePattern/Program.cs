using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype proto = new ConcretePrototype1("protoID_1");
            Console.WriteLine("proto hash {0}, proto id {1}", proto.GetHashCode(), proto.Id);
            Prototype clone1 = proto.Clone();
            Console.WriteLine("proto hash {0}, proto id {1}", clone1.GetHashCode(), clone1.Id);


            proto = new ConcretePrototype2("protoID_2");
            Console.WriteLine("proto hash {0}, proto id {1}", proto.GetHashCode(), proto.Id);
            Prototype clone2 = proto.Clone();
            Console.WriteLine("proto hash {0}, proto id {1}", clone2.GetHashCode(), clone2.Id);

            Console.ReadLine();
        }
    }
}
