using System.ComponentModel;
using System.Xml.Linq;

namespace ContextualHelpGui.Components;

public abstract class Component : IComponentWithContextualHelp
{
    private Container? container; // Keep it private
    protected string? tooltipText;

    public Component(Container? container = null, string? tooltipText = null)
    {
        this.container = container;
        this.tooltipText = tooltipText;
    }

    public void SetContainer(Container container)
    {
        this.container = container;
    }

    public virtual void ShowHelp()
    {
        if (!string.IsNullOrEmpty(tooltipText))
        {
            Console.WriteLine($"Tooltip: {tooltipText}");
        }
        else
        {
            container?.ShowHelp();
        }
    }
}