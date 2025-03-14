using System.Data.SqlTypes;

namespace DatabaseSettings;

public class Database
{
    private static Database? _instance;
    private static readonly object _lock = new();

    private Database()
    {

    }

    public static Database GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock) // Ensures thread safety
            {
                if (_instance == null)
                {
                    _instance = new Database();
                }
            }
        }
        return _instance;
    }

    public void Query(string Sql)
    {
        Console.WriteLine($"Query to database using ({Sql}).");
    }
}
