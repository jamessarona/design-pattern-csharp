using GuiFactory.Button;
using GuiFactory.Checkbox;

namespace GuiFactory.Gui;

public interface IGuiFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}
