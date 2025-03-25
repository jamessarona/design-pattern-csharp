namespace DataEncrypter.Base;

public interface IDataSource
{
    void WriteData(string data);
    string ReadData();
}