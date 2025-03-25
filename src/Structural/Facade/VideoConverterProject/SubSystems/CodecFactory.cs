namespace VideoConverterProject.SubSystems;

public static class CodecFactory
{
    public static ICodec Extract(VideoFile file)
    {
        Console.WriteLine($"Extracting codec for format {file.Format}");
        return file.Format.ToLower() == "ogg" ? new OggCompressionCodec() : new Mpeg4CompressionCodec();
    }
}