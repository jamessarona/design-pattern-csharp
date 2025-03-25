using DataEncrypter.Base;

public class SalaryManager
{
    private readonly IDataSource _source;

    public SalaryManager(IDataSource source)
    {
        _source = source;
    }

    public void Save(string salaryData)
    {
        _source.WriteData(salaryData);
    }

    public string Load()
    {
        return _source.ReadData();
    }
}