using DataEncrypter.Base;

namespace DataEncrypter.DataSource;

public class FileDataSource : IDataSource
{
    private string filename;
    
    public FileDataSource(string filename)
    {
        this.filename = filename;
    }
    public void WriteData(string data)
    {
        File.WriteAllText(filename, data);
    }

    public string ReadData()
    {
        return File.Exists(filename) ? File.ReadAllText(filename) : string.Empty;
    }
}