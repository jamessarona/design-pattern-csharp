using YoutubeManager.Models;
using YoutubeManager.Services;

namespace YoutubeManager;

public interface IThirdPartyYoutubeLib
{
    List<Video> ListVideos();
    Video GetVideoInfo(string id);
    void DownloadVideo(string id);
}