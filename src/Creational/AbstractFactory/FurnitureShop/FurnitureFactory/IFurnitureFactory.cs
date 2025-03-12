using AbstractFactory.Chair;
using AbstractFactory.CoffeeTable;
using AbstractFactory.Sofa;

namespace AbstractFactory.Interfaces;

interface IFurnitureFactory
{
    IChair CreateChair();
    ICoffeeTable CreateCoffeeTable();
    ISofa CreateSofa();
}
