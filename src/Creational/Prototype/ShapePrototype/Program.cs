
using ShapePrototype.Concrete;

Rectangle rect1 = new Rectangle { X = 10, Y = 20, Color = "Red", Width = 100, Height = 50 };
Rectangle rect2 = (Rectangle)rect1.Clone();

Console.WriteLine($"Rectangle1: X={rect1.X}, Y={rect1.Y}, Color={rect1.Color}, Width={rect1.Width}, Height={rect1.Height}");
Console.WriteLine($"Rectangle2: X={rect2.X}, Y={rect2.Y}, Color={rect2.Color}, Width={rect2.Width}, Height={rect2.Height}");

Circle circle1 = new Circle { X = 15, Y = 25, Color = "Blue", Radius = 30 };
Circle circle2 = (Circle)circle1.Clone();

Console.WriteLine($"Circle1: X={circle1.X}, Y={circle1.Y}, Color={circle1.Color}, Radius={circle1.Radius}");
Console.WriteLine($"Circle2: X={circle2.X}, Y={circle2.Y}, Color={circle2.Color}, Radius={circle2.Radius}");
