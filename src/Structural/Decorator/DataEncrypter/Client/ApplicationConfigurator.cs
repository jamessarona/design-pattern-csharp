using DataEncrypter.Base;
using DataEncrypter.DataSource;
using DataEncrypter.Decorators;

namespace DataEncrypter.Client;

public class ApplicationConfigurator
{
    public static void ConfigurationExample(bool enableEncryption, bool enableCompression)
    {
        IDataSource source = new FileDataSource("salary.dat");

        if (enableCompression)
        {
            source = new CompressionDecorator(source);
        }
        if (enableEncryption)
        {
            source = new EncryptionDecorator(source);
        }

        SalaryManager manager = new SalaryManager(source);

        string salaryRecords = "EmployeeSalary1234";
        Console.WriteLine("Original Data: " + salaryRecords);

        // Save Data
        manager.Save(salaryRecords);
        Console.WriteLine("Data saved to file.");

        // Load Data
        string loadedData = manager.Load();
        Console.WriteLine("Loaded Data: " + loadedData);
    }
}
