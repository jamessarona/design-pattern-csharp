using TextEditor.Core;

namespace TextEditor.Commands;
public class PasteCommand : Command
{
    public PasteCommand(Application app, Editor editor) : base(app, editor) { }

    public override bool Execute()
    {
        SaveBackup();
        Editor.ReplaceSelection(App.Clipboard);
        return true;
    }
}