namespace PrototypePattern
{
    public class ConcretePrototype1:Prototype
    {
        public ConcretePrototype1(string Id):base(Id)
        {

        }

        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }
}
