using TextEditor.Commands;
using TextEditor.Core;

var app = new Application();
var editor = new Editor();
app.ActiveEditor = editor;
app.Editors.Add(editor);

editor.Text = "Hello World";

app.ExecuteCommand(new CopyCommand(app, editor));
app.ExecuteCommand(new CutCommand(app, editor));
app.ExecuteCommand(new PasteCommand(app, editor));
app.ExecuteCommand(new UndoCommand(app, editor));

Console.WriteLine("Editor text: " + editor.Text);
