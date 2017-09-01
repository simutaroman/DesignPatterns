using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponent();
            Decorator decoratorA = new ConcreteDecoratorA();
            Decorator decoratorB = new ConcreteDecoratorB();
            decoratorA.SetComponent(component);
            decoratorB.SetComponent(decoratorA);
            decoratorB.Operation();
        }
    }
}
