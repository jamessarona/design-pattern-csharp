using TextEditor.Commands;

namespace TextEditor.Core;

public class CommandHistory
{
    public Stack<Command> history = new();

    public void Push(Command command) => history.Push(command);

    public Command? Pop() => history.Count > 0 ? history.Pop() : null;
}
