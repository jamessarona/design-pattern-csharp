using Colors;

namespace Shapes;

public class Circle : Shape
{
    public Circle(IColor color) : base(color)
    {

    }

    public override string Draw()
    {
        return $"Draw Circle in {Color.GetColor()}";
    }
}
