namespace SampleComposite;

// Composite Class
public class Composite : IComponent
{
    private readonly List<IComponent> _children = new List<IComponent>();

    public void Add(IComponent component)
    {
        _children.Add(component);
    }

    public void Remove(IComponent component)
    {
        _children.Remove(component);
    }

    public List<IComponent> GetChildren()
    {
        return _children;
    }

    public void Execute()
    {
        Console.WriteLine("Composite: Delegating work to children.");
        foreach (var component in _children)
        {
            component.Execute();
        }
    }
}