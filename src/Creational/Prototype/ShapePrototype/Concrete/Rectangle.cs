using ShapePrototype.Base;

namespace ShapePrototype.Concrete;

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle() { }

    public Rectangle(Rectangle source) : base(source)
    {
        if (source != null)
        {
            Width = source.Width;
            Height = source.Height;
        }
    }

    public override Shape Clone()
    {
        return new Rectangle(this);
    }
}
