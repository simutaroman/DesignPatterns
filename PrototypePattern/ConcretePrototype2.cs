namespace PrototypePattern
{
    class ConcretePrototype2:Prototype
    {
        public ConcretePrototype2(string Id):base(Id)
        {

        }

        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id);
        }
    }
}
