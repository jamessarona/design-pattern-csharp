using TreeObjectLibrary.Client;

Forest forest = new Forest();

forest.PlantTree(10, 20, "Oak", "Green", "Rough Bark");
forest.PlantTree(30, 40, "Pine", "Dark Green", "Smooth Bark");
forest.PlantTree(50, 60, "Oak", "Green", "Rough Bark"); // Reuses existing "Oak" type

forest.Draw("MyCanvas");