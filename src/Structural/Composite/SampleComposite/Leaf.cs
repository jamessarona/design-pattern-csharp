namespace SampleComposite;

// Leaf Class
public class Leaf : IComponent
{
    public void Execute()
    {
        Console.WriteLine("Leaf: Doing some work.");
    }
}