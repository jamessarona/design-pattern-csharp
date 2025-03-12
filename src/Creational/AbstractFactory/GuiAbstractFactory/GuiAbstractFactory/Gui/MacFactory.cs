using GuiFactory.Button;
using GuiFactory.Checkbox;

namespace GuiFactory.Gui;

public class MacFactory : IGuiFactory
{
    public MacFactory()
    {
        Console.WriteLine("Mac Theme");
    }

    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}
