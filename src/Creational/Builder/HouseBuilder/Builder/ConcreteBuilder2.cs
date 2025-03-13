using HouseBuilder.Product;

namespace HouseBuilder.Builder;

public class ConcreteBuilder2 : IBuilder
{
    private Product2 _product = new Product2();
    public void BuildStepA()
    {
        _product.FeatureA = "Feature A2";
    }

    public void BuildStepB()
    {
        _product.FeatureB = "Feature B2";
    }

    public void BuildStepZ()
    {
        _product.FeatureZ = "Feature Z2";
    }

    public void Reset()
    {
        _product = new Product2();
    }

    public Product2 GetResult()
    {
        return _product;
    }
}
