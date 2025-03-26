using YoutubeManager.Services;
using YoutubeManager;
using YoutubeManager.Managers;

IThirdPartyYoutubeLib realService = new ThirdPartyYoutubeClass();
IThirdPartyYoutubeLib cachedService = new CachedYoutubeClass(realService);
YoutubeManagers manager = new YoutubeManagers(cachedService);

manager.RenderVideoList();  // First time: Fetch from YouTube (cache miss)
manager.RenderVideoList();  // Second time: Fetch from cache (cache hit)

manager.RenderVideoPage("1"); // First time: Fetch from YouTube (cache miss)
manager.RenderVideoPage("1"); // Second time: Fetch from cache (cache hit)

manager.DownloadVideo("1"); // No caching applied, always fetch from YouTube

Console.WriteLine("\nInvalidating cache...");
((CachedYoutubeClass)cachedService).InvalidateCache();

manager.RenderVideoList(); // After cache invalidation: Fetch from YouTube again