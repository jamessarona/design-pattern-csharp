namespace ContextualHelpGui.Components;

public class Container : Component
{
    private readonly List<Component> children = new List<Component>();

    public void Add(Component child)
    {
        children.Add(child);
        child.SetContainer(this); // Use setter method
    }

    public override void ShowHelp()
    {
        Console.WriteLine("Container Help: Default help for this container.");
    }
}