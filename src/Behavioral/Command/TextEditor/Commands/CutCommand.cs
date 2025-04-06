using TextEditor.Core;

namespace TextEditor.Commands;

public class CutCommand : Command
{
    public CutCommand(Application app, Editor editor) : base(app, editor) { }

    public override bool Execute()
    {
        SaveBackup();
        App.Clipboard = Editor.GetSelection();
        Editor.DeleteSelection();
        return true;
    }
}