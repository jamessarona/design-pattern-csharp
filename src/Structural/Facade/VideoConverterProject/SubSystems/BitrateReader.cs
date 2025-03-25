namespace VideoConverterProject.SubSystems;

public static class BitrateReader
{
    public static VideoFile Read(string fileName)
    {
        Console.WriteLine($"Reading bitrate from {fileName}");
        return new VideoFile(fileName);
    }

    public static void Write(VideoFile file)
    {
        Console.WriteLine($"Writing bitrate for {file.FileName}");
    }
}