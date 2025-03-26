using YoutubeManager.Models;

namespace YoutubeManager.Services;

public class CachedYoutubeClass : IThirdPartyYoutubeLib
{
    private readonly IThirdPartyYoutubeLib _service;
    private List<Video>? _cachedVideos;
    private Dictionary<string, Video> _cachedVideoInfo;
    private bool _cacheExpired;

    public CachedYoutubeClass(IThirdPartyYoutubeLib service)
    {
        _service = service;
        _cachedVideos = null;
        _cachedVideoInfo = new Dictionary<string, Video>();
        _cacheExpired = true;
    }

    public List<Video> ListVideos()
    {
        if (_cachedVideos == null || _cacheExpired)
        {
            Console.WriteLine("Cache miss: Fetching video list from YouTube...");
            _cachedVideos = _service.ListVideos();
            _cacheExpired = false;
        }
        else
        {
            Console.WriteLine("Cache hit: Returning cached video list.");
        }
        return _cachedVideos;
    }

    public Video GetVideoInfo(string id)
    {
        if (!_cachedVideoInfo.ContainsKey(id))
        {
            Console.WriteLine($"Cache miss: Fetching video info for ID: {id} from YouTube...");
            var video = _service.GetVideoInfo(id);
            _cachedVideoInfo[id] = video;
        }
        else
        {
            Console.WriteLine($"Cache hit: Returning cached info for video ID: {id}.");
        }
        return _cachedVideoInfo[id];
    }

    public void DownloadVideo(string id)
    {
        Console.WriteLine($"Downloading video ID: {id} (no caching applied)...");
        _service.DownloadVideo(id);
    }

    public void InvalidateCache()
    {
        Console.WriteLine("Invalidating cache...");
        _cacheExpired = true;
        _cachedVideos = null;
        _cachedVideoInfo.Clear();
    }
}
