using HouseBuilder.Product;

namespace HouseBuilder.Builder;

public class ConcreteBuilder1 : IBuilder
{
    private Product1 _product = new Product1();

    public void BuildStepA()
    {
        _product.FeatureA = "Feature A1";
    }

    public void BuildStepB()
    {
        _product.FeatureB = "Feature B1";
    }

    public void BuildStepZ()
    {
        _product.FeatureZ = "Feature Z1";
    }

    public void Reset()
    {
        _product = new Product1();
    }

    public Product1 GetResult()
    {
        return _product;
    }
}