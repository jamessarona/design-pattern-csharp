using SamplePrototype;

// Create a Concrete Prototype
ConcretePrototype original = new ConcretePrototype("Value1");
ConcretePrototype copy = (ConcretePrototype)original.Clone();
Console.WriteLine($"Original: {original.Field1}, Copy: {copy.Field1}");

// Create a Subclass Prototype
SubclassPrototype subclassOriginal = new SubclassPrototype("Value1", "Value2");
SubclassPrototype subclassCopy = (SubclassPrototype)subclassOriginal.Clone();
Console.WriteLine($"Original: {subclassOriginal.Field1}, {subclassOriginal.Field2}");
Console.WriteLine($"Copy: {subclassCopy.Field1}, {subclassCopy.Field2}");