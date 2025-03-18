namespace ImageEditorComposite;

public class Circle : Dot
{
    private int Radius;

    public Circle(int x, int y, int radius) : base(x, y)
    {
        Radius = radius;
    }

    public new void Draw()
    {
        Console.WriteLine($"Drawing a circle at ({X}, {Y}) with radius {Radius}");
    }
}
