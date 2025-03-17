using Colors;

namespace Shapes;

public class Square : Shape
{
    public Square(IColor color) : base(color) { }

    public override string Draw()
    {
        return $"Drawing Square in {Color.GetColor()}";
    }
}