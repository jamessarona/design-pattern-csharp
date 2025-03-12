using AbstractFactory.FurnitureFactory;
using AbstractFactory.Interfaces;

IFurnitureFactory furnitureFactory;

furnitureFactory = new ModernFurnitureFactory();
furnitureFactory.CreateChair().SitOn();
furnitureFactory.CreateCoffeeTable().PlaceItems();
furnitureFactory.CreateSofa().LieOn();

furnitureFactory = new VictorianFurnitureFactory();
furnitureFactory.CreateChair().SitOn();
furnitureFactory.CreateCoffeeTable().PlaceItems();
furnitureFactory.CreateSofa().LieOn();