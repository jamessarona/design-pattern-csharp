namespace ImageEditorComposite;

// Client Class
public class ImageEditor
{
    private CompoundGraphic _allGraphics = new CompoundGraphic();

    public void Load()
    {
        // Adding individual graphics (Dot and Circle)
        _allGraphics.Add(new Dot(1, 2));
        _allGraphics.Add(new Circle(5, 5, 3));

        // Creating a nested compound graphic
        CompoundGraphic group = new CompoundGraphic();
        group.Add(new Dot(10, 10));
        group.Add(new Circle(15, 15, 5));

        // Adding the nested group to the main compound graphic
        _allGraphics.Add(group);
    }

    public void Move(int x, int y)
    {
        Console.WriteLine($"Moving all graphics by ({x}, {y})");
        _allGraphics.Move(x, y);
    }

    public void Draw()
    {
        Console.WriteLine("Rendering all graphics:");
        _allGraphics.Draw();
    }
}