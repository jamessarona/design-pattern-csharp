using DataEncrypter.Base;

namespace DataEncrypter.Decorators;

public class DataSourceDecorator : IDataSource
{
    private IDataSource wrappee;

    public DataSourceDecorator(IDataSource wrappee)
    {
        this.wrappee = wrappee;
    }

    public virtual void WriteData(string data)
    {
        wrappee.WriteData(data);
    }

    public virtual string ReadData()
    {
        return wrappee.ReadData();
    }
}