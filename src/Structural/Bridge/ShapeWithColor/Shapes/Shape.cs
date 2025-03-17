using Colors;

namespace Shapes;

// Abstraction (Shape)
public abstract class Shape
{
    protected IColor Color;

    protected Shape(IColor color)
    {
        Color = color;
    }

    public abstract string Draw();
}