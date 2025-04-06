using TextEditor.Core;

namespace TextEditor.Commands;

public class UndoCommand : Command
{
    public UndoCommand(Application app, Editor editor) : base(app, editor) { }

    public override bool Execute()
    {
        App.Undo();
        return false;
    }
}
