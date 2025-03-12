using AbstractFactory.Chair;
using AbstractFactory.CoffeeTable;
using AbstractFactory.Interfaces;
using AbstractFactory.Sofa;

namespace AbstractFactory.FurnitureFactory
{
    class VictorianFurnitureFactory : IFurnitureFactory
    {
        public VictorianFurnitureFactory()
        {
            Console.WriteLine("Victorian Theme");
        }

        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}