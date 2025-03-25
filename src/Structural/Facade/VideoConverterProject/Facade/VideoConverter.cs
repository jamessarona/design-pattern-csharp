using VideoConverterProject.SubSystems;

namespace VideoConverterProject.Facade;

public class VideoConverter
{
    public void ConvertVideo(string fileName, string targetFormat)
    {
        Console.WriteLine($"Starting video conversion: {fileName} -> {targetFormat}");

        VideoFile file = BitrateReader.Read(fileName);
        ICodec sourceCodec = CodecFactory.Extract(file);

        ICodec targetCodec = targetFormat.ToLower() == "ogg" ? new OggCompressionCodec() : new Mpeg4CompressionCodec();

        Console.WriteLine($"Converting {file.FileName} from {sourceCodec.CodecName} to {targetCodec.CodecName}");

        BitrateReader.Write(file);

        AudioMixer audioMixer = new AudioMixer();
        audioMixer.FixAudio(file);

        Console.WriteLine($"Conversion completed: {file.FileName}.{targetFormat}");
    }
}