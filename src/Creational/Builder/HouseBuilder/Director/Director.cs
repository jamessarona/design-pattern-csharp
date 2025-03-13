using HouseBuilder.Builder;

namespace HouseBuilder.Director;

public class Director
{
    private IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }

    public void ChangeBuilder(IBuilder builder)
    {
        _builder = builder;
    }

    public void Make(string type)
    {
        _builder.Reset();
        if (type == "simple")
        {
            _builder.BuildStepA();
        }
        else
        {
            _builder.BuildStepB();
            _builder.BuildStepZ();
        }

    }
}
