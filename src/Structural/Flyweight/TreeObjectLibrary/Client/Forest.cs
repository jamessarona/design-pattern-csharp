using TreeObjectLibrary.Factories;
using TreeObjectLibrary.Models;

namespace TreeObjectLibrary.Client;

public class Forest
{
    public List<Tree> Trees = new List<Tree>();

    public void PlantTree(int X, int Y, string Name, string Color, string Texture) 
    {
        TreeType Type = TreeFactory.GetTreeType(Name, Color, Texture);
        Tree Tree = new Tree(X, Y, Type);
        Trees.Add(Tree);
    }

    public void Draw(string Canvas)
    {
        Console.WriteLine("Forest is " + Canvas);
        foreach (var Tree in Trees)
        {
            Tree.Draw();
        }
    }
}
