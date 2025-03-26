namespace YoutubeManager.Models;

public class Video
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }

    public Video(string id, string title, string description, string url)
    {
        Id = id;
        Title = title;
        Description = description;
        Url = url;
    }
}
