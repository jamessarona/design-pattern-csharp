namespace TreeObjectLibrary.Models;

public class TreeType
{
    public string Name { get; }
    public string Color { get; }
    public string Texture { get; }

    public TreeType(string Name, string Color, string Texture)
    {
        this.Name = Name;
        this.Color = Color;
        this.Texture = Texture;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Drawing tree '{Name}' at ({x}, {y}) with color {Color} and texture {Texture}.");
    }
}
