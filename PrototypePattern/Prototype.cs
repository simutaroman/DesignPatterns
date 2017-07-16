namespace PrototypePattern
{
    public abstract class Prototype
    {
        public string Id { get; private set; }

        public Prototype(string Id)
        {
            this.Id = Id;
        }

        public abstract Prototype Clone();
    }
}
