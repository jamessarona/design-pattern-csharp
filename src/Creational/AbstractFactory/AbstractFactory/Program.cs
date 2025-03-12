using AbstractFactory.FurnitureFactory;
using AbstractFactory.Interfaces;

IFurnitureFactory furnitureFactory;

Console.WriteLine("Furnitures are Modern");
furnitureFactory = new ModernFurnitureFactory();

furnitureFactory.CreateChair().SitOn();
furnitureFactory.CreateCoffeeTable().PlaceItems();
furnitureFactory.CreateSofa().LieOn();


Console.WriteLine("Furnitures changed to Victorian");
furnitureFactory = new VictorianFurnitureFactory();
furnitureFactory.CreateChair().SitOn();
furnitureFactory.CreateCoffeeTable().PlaceItems();
furnitureFactory.CreateSofa().LieOn();