using DatabaseSettings;

Database databaseInstance1 = Database.GetInstance();
databaseInstance1.Query("SELECT * FROM Item");

Database databaseInstance2 = Database.GetInstance();
databaseInstance2.Query("SELECT * FROM Product");
Console.WriteLine(ReferenceEquals(databaseInstance1, databaseInstance2));