namespace SamplePrototype;

public class ConcretePrototype : IPrototype
{
    public string Field1 { get; set; }

    public ConcretePrototype(string field1)
    {
        Field1 = field1;
    }

    // Copy Constructor for Cloning
    public ConcretePrototype(ConcretePrototype prototype)
    {
        Field1 = prototype.Field1;
    }
    public IPrototype Clone()
    {
        return new ConcretePrototype(this);
    }
}
