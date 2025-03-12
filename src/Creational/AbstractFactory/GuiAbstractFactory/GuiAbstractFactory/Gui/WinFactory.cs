using GuiFactory.Button;
using GuiFactory.Checkbox;

namespace GuiFactory.Gui;

class WinFactory : IGuiFactory
{
    public WinFactory()
    {
        Console.WriteLine("Window Theme");
    }

    public IButton CreateButton()
    {
        return new WinButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WinCheckbox();
    }
}
