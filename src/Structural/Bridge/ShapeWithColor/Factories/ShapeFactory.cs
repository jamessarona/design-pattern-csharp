using Colors;
using Shapes;

namespace Factories;

class ShapeFactory
{
    public static Shape CreateShape(string shapeType, string colorType)
    {
        IColor color = colorType == "Read" ? new Red() : new Blue();

        return shapeType switch
        {
            "Circle" => new Circle(color),
            "Square" => new Square(color),
            _ => throw new ArgumentException("Invalid shape type")
        };
    }
}
