namespace ImageEditorComposite;

public class CompoundGraphic : IGraphic
{
    private readonly List<IGraphic> children = new List<IGraphic>();

    public void Add(IGraphic child)
    {
        children.Add(child);
    }

    public void Remove(IGraphic child)
    {
       children.Remove(child);
    }

    public void Move(int x, int y)
    {
        Console.WriteLine($"Moving CompoundGraphic by ({x}, {y})");
        foreach (var child in children)
        {
            child.Move(x, y);
        }
    }

    public void Draw()
    {
        Console.WriteLine("Drawing CompoundGraphic:");
        foreach (var child in  children)
        {
            child.Draw();
        }
    }
}
