using DataEncrypter.Base;
using DataEncrypter.Decorators;
using System.IO.Compression;
using System.Text;

public class CompressionDecorator : DataSourceDecorator
{
    public CompressionDecorator(IDataSource wrappee) : base(wrappee) { }

    public override void WriteData(string data)
    {
        string compressedData = Compress(data);
        base.WriteData(compressedData);
    }

    public override string ReadData()
    {
        string compressedData = base.ReadData();
        return Decompress(compressedData);
    }

    private string Compress(string data)
    {
        byte[] dataBytes = Encoding.UTF8.GetBytes(data);

        using (var outputStream = new MemoryStream())
        {
            using (var gzipStream = new GZipStream(outputStream, CompressionMode.Compress))
            {
                gzipStream.Write(dataBytes, 0, dataBytes.Length);
            }
            return Convert.ToBase64String(outputStream.ToArray()); // Store as Base64
        }
    }

    private string Decompress(string compressedData)
    {
        byte[] compressedBytes = Convert.FromBase64String(compressedData);

        using (var inputStream = new MemoryStream(compressedBytes))
        using (var gzipStream = new GZipStream(inputStream, CompressionMode.Decompress))
        using (var outputStream = new MemoryStream())
        {
            gzipStream.CopyTo(outputStream);
            return Encoding.UTF8.GetString(outputStream.ToArray());
        }
    }
}