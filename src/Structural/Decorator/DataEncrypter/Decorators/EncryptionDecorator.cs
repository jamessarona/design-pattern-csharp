using System;
using System.Text;

using DataEncrypter.Base;

namespace DataEncrypter.Decorators;

public class EncryptionDecorator : DataSourceDecorator
{
    public EncryptionDecorator(IDataSource wrappee) : base(wrappee)
    {
    }

    public override void WriteData(string data)
    {
        string encryptedData = Encrypt(data);
        base.WriteData(encryptedData);
    }

    public override string ReadData()
    {
        string encryptedData = base.ReadData();
        return Decrypt(encryptedData);
    }

    private string Encrypt(string data)
    {
        // Simple Base64 Encoding (for demonstration)
        byte[] dataBytes = Encoding.UTF8.GetBytes(data);
        return Convert.ToBase64String(dataBytes);
    }

    private string Decrypt(string encryptedData)
    {
        // Decode Base64 back to original string
        byte[] dataBytes = Convert.FromBase64String(encryptedData);
        return Encoding.UTF8.GetString(dataBytes);
    }
}
