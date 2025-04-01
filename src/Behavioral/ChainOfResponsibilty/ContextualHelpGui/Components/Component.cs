using System.ComponentModel;
using System.Xml.Linq;

namespace ContextualHelpGui.Components;

public abstract class Component : IComponentWithContextualHelp
{
    protected Container container { get; private set; }
    protected string tooltipText;

    public Component(Container container, string tooltipText)
    {
        this.container = container;
        this.tooltipText = tooltipText;
    }
    protected void SetContainer(Container newContainer)
    {
        container = newContainer;
    }

    public void ShowHelp()
    {
        if (!string.IsNullOrEmpty(tooltipText))
        {
            Console.WriteLine($"Tooltip: {tooltipText}");
        }
        else if (container != null)
        {
            container.ShowHelp();
        }
    }
}