using HouseBuilder.Builder;
using HouseBuilder.Director;
using HouseBuilder.Product;

ConcreteBuilder1 builder1 = new ConcreteBuilder1();

Director director = new Director(builder1);

director.Make("simple");
Product1 product1 = builder1.GetResult();

Console.WriteLine($"Product1: A={product1.FeatureA}, B={product1.FeatureB}, Z={product1.FeatureZ}");


// Change the builder
ConcreteBuilder2 builder2 = new ConcreteBuilder2();
director.ChangeBuilder(builder2);

director.Make("other");
Product2 product2 = builder2.GetResult();

Console.WriteLine($"Product2: A={product2.FeatureA}, B={product1.FeatureB}, Z={product1.FeatureZ}");
