using YoutubeManager.Models;

namespace YoutubeManager.Services;

public class ThirdPartyYoutubeClass : IThirdPartyYoutubeLib
{
    public List<Video> ListVideos()
    {
        Console.WriteLine("Fetching video list from YouTube...");
        return new List<Video>
        {
            new Video("1", "Intro to C#", "A beginner's guide to C#", "https://youtube.com/video1"),
            new Video("2", "Design Patterns", "Understanding design patterns", "https://youtube.com/video2")
        };
    }

    public Video GetVideoInfo(string id)
    {
        Console.WriteLine($"Fetching video info for ID: {id} from YouTube...");
        return new Video(id, "Sample Video", "This is a sample video description", $"https://youtube.com/video{id}");
    }

    public void DownloadVideo(string id)
    {
        Console.WriteLine($"Downloading video ID: {id} from YouTube...");
    }
}
