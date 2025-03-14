namespace SamplePrototype;

public class SubclassPrototype : ConcretePrototype
{
    public string Field2 { get; set; }

    public SubclassPrototype(string field1, string field2) : base(field1)
    {
        Field2 = field2;
    }

    public SubclassPrototype(SubclassPrototype prototype) : base(prototype)
    {
        Field2 = prototype.Field2;
    }

    public new IPrototype Clone()
    {
        return new SubclassPrototype(this);
    }

}
