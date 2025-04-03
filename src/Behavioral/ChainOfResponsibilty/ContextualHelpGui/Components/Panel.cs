namespace ContextualHelpGui.Components;

public class Panel : Container
{
    private readonly string? modalHelpText;

    public Panel(string? modalHelpText = null)
    {
        this.modalHelpText = modalHelpText;
    }

    public override void ShowHelp()
    {
        if (!string.IsNullOrEmpty(modalHelpText))
        {
            Console.WriteLine($"Modal Help: {modalHelpText}");
        }
        else
        {
            base.ShowHelp();
        }
    }
}
