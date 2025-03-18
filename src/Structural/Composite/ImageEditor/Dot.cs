namespace ImageEditorComposite;

// Leaf Class (Single Graphic Object)
public class Dot : IGraphic
{
    protected int X, Y;

    public Dot(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(int x, int y)
    {
        X += x;
        Y += y;
        Console.WriteLine($"Dot moved to ({X}, {Y})");
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a dot at ({X}, {Y})");
    }
}