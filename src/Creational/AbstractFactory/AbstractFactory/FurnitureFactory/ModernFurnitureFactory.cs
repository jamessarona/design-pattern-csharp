using AbstractFactory.Chair;
using AbstractFactory.CoffeeTable;
using AbstractFactory.Interfaces;
using AbstractFactory.Sofa;

namespace AbstractFactory.FurnitureFactory;

class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ICoffeeTable CreateCoffeeTable()
    {
        return new ModernCoffeeTable();
    }

    public ISofa CreateSofa()
    {
        return new ModernSofa();
    }
}
