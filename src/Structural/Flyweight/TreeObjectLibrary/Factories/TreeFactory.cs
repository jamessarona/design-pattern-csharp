using TreeObjectLibrary.Models;

namespace TreeObjectLibrary.Factories;

public class TreeFactory
{
    private static Dictionary<string, TreeType> TreeTypes = new Dictionary<string, TreeType>();
    
    public static TreeType GetTreeType(string Name, string Color, string Texture)
    {
        string key = $"{Name}_{Color}_{Texture}";

        if (!TreeTypes.ContainsKey(key))
        {
            TreeTypes[key] = new TreeType(Name, Color, Texture);
            Console.WriteLine($"Created new TreeType: {Name}, Color: {Color}, Texture: {Texture}");
        }
        else
        {
            Console.WriteLine($"Reusing existing TreeType: {Name}, Color: {Color}, Texture: {Texture}");
        }

        return TreeTypes[key];
    }
}