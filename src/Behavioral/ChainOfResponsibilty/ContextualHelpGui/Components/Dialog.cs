namespace ContextualHelpGui.Components;

public class Dialog : Container
{
    private readonly string? wikiPageUrl;

    public Dialog(string? wikiPageUrl = null)
    {
        this.wikiPageUrl = wikiPageUrl;
    }

    public override void ShowHelp()
    {
        if (!string.IsNullOrEmpty(wikiPageUrl))
        {
            Console.WriteLine($"Opening Wiki Page: {wikiPageUrl}");
        }
        else
        {
            base.ShowHelp();
        }
    }
}