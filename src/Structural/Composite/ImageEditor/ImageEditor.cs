namespace ImageEditorComposite;

// Client Class
public class ImageEditor
{
    private CompoundGraphic all = new CompoundGraphic();

    public void Load()
    {
        all.Add(new Dot(1, 2));
        all.Add(new Circle(5, 3, 10));
    }

    public void GroupSelected(List<IGraphic> components)
    {
        CompoundGraphic group = new CompoundGraphic();

        foreach (var component in components)
        {
            group.Add(component);
            all.Remove(component);
        }

        all.Add(group);
        all.Draw(); // Draw all components
    }
}