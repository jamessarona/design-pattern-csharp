namespace VideoConverterProject.SubSystems;

public class VideoFile
{
    public string FileName { get; }
    public string Format { get; }

    public VideoFile(string fileName)
    {
        FileName = fileName;
        Format = fileName.Substring(fileName.LastIndexOf('.') + 1);
    }
}
