namespace YoutubeManager.Managers;

public class YoutubeManagers
{
    private readonly IThirdPartyYoutubeLib _youtubeService;

    public YoutubeManagers(IThirdPartyYoutubeLib youtubeService)
    {
        _youtubeService = youtubeService;
    }

    public void RenderVideoPage(string videoId)
    {
        Console.WriteLine("\n--- Video Page ---");

        var video = _youtubeService.GetVideoInfo(videoId);
        Console.WriteLine($"Title: {video.Title}");
        Console.WriteLine($"Description: {video.Description}");
        Console.WriteLine($"URL: {video.Url}\n");
    }

    public void RenderVideoList()
    {
        Console.WriteLine("\n--- Video List ---");
        var videos = _youtubeService.ListVideos();
        foreach (var video in videos)
        {
            Console.WriteLine($"[{video.Id}] {video.Title}");
        }
        Console.WriteLine();
    }

    public void DownloadVideo(string videoId)
    {
        _youtubeService.DownloadVideo(videoId);
    }
}
