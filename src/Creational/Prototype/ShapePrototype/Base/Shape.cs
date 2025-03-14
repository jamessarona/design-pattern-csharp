using System.Drawing;

namespace ShapePrototype.Base;


public abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Color { get; set; }

    public Shape() { }

    public Shape(Shape source)
    {
        if (source != null)
        {
            X = source.X;
            Y = source.Y;
            Color = source.Color;
        }
    }

    public abstract Shape Clone();
}
