using GuiFactory.Application;
using GuiFactory.Gui;

Console.WriteLine("Choose GUI style (Windows/Mac): ");
string style = Console.ReadLine();

Application application;
if (style == "Mac")
    application = new Application(new MacFactory());
else if (style == "Windows")
    application = new Application(new WinFactory());
else
    throw new ArgumentException("Invalid GUI style.");

application.CreateUI();
application.Paint();