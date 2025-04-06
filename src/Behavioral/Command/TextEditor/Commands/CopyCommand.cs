using TextEditor.Core;

namespace TextEditor.Commands;

public class CopyCommand : Command
{
    public CopyCommand(Application app, Editor editor) : base(app, editor) { }

    public override bool Execute()
    {
        App.Clipboard = Editor.GetSelection();
        return false; // No need to undo copy
    }
}
