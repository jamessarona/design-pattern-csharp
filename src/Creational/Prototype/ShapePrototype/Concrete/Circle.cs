using ShapePrototype.Base;

namespace ShapePrototype.Concrete;

public class Circle : Shape
{
    public int Radius { get; set; }

    public Circle()
    {
    }

    public Circle(Circle source) : base(source)
    {
        if (source != null)
        {
            Radius = source.Radius;
        }
    }

    public override Shape Clone()
    {
        return new Circle(this);
    }
}