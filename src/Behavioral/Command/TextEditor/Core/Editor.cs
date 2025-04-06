namespace TextEditor.Core;

public class Editor
{
    public string Text { get; set; } = default!;

    public string GetSelection() => Text;
    public void DeleteSelection() => Text = string.Empty;

    public void ReplaceSelection(string text) => Text = text;
}