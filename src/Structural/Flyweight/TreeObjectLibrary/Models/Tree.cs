namespace TreeObjectLibrary.Models;

public class Tree
{
    public int X { get; }
    public int Y { get; }
    public TreeType Type { get; }

    public Tree(int X, int Y, TreeType Type)
    {
        this.X = X;
        this.Y = Y;
        this.Type = Type;
    }

    public void Draw()
    {
        Type.Draw(X, Y);
    }
}