using TextEditor.Commands;

namespace TextEditor.Core;

public class Application
{
    public List<Editor> Editors { get; set; } = new();
    public Editor? ActiveEditor { get; set; }
    public string? Clipboard { get; set; }
    public CommandHistory History { get; set; } = new();

    public void ExecuteCommand(Command command)
    {
        if (command.Execute())
        {
            History.Push(command);
        }
    }

    public void Undo()
    {
        var command = History.Pop();
        command?.Undo();
    }

    public void CreateUI()
    {
        // Simulate UI
    }
}
