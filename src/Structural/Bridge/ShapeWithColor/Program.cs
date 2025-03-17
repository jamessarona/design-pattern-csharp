using Factories;
using Shapes;

Shape shape1 = ShapeFactory.CreateShape("Circle", "Blue");
Console.WriteLine(shape1.Draw()); // Output: Drawing Circle in Blue

Shape shape2 = ShapeFactory.CreateShape("Square", "Red");
Console.WriteLine(shape2.Draw()); // Output: Drawing Square in Red