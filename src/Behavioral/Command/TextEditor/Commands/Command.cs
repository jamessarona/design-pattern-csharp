using TextEditor.Core;

namespace TextEditor.Commands;

public abstract class Command
{
    private Application App;
    private Editor Editor;
    private string Backup;

    public Command(Application app, Editor editor)
    {
        App = app;
        Editor = editor;
    }

    protected void SaveBackup() => Backup = Editor.Text;

    public virtual void Undo() => Editor.Text = Backup;

    public abstract bool Execute();
}
