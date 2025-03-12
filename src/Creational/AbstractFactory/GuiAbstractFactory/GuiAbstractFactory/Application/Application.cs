using GuiFactory.Button;
using GuiFactory.Checkbox;
using GuiFactory.Gui;

namespace GuiFactory.Application;

public class Application
{
    private IGuiFactory Factory;
    private IButton Button;
    private ICheckbox Checkbox;

    public Application(IGuiFactory NewFactory)
    {
        Factory = NewFactory;
    }

    public void CreateUI()
    {
        Button = Factory.CreateButton();
        Checkbox = Factory.CreateCheckbox();
    }

    public void Paint()
    {
        Button.Paint();
        Checkbox.Paint();
    }

}
