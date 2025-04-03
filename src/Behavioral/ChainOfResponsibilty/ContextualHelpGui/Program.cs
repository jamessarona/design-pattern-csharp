using ContextualHelpGui.Components;

Dialog dialog = new Dialog("https://help.example.com");
Panel panel = new Panel("This is a help panel.");
Button button = new Button("Click this button.");

dialog.Add(panel);
panel.Add(button);

button.ShowHelp(); // Shows tooltip
panel.ShowHelp();  // Shows modal help text
dialog.ShowHelp(); // Opens the wiki page