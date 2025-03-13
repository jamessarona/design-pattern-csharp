using CarBuilder.Builder;
using CarBuilder.Director;
using CarBuilder.Model;

Director director = new Director();

// Build a Sports Car
RealCarBuilder sportsCarBuilder = new RealCarBuilder();
director.MakeSportsCar(sportsCarBuilder);
Car sportsCar = sportsCarBuilder.GetResult();
Console.WriteLine($"Sports Car: Seats={sportsCar.Seats}, Engine={sportsCar.Engine}, GPS={sportsCar.HasGPS}, TripComputer={sportsCar.HasTripComputer}");

// Build a Manual for Sports Car
CarManualBuilder sportsCarManualBuilder = new CarManualBuilder();
director.MakeSportsCar(sportsCarManualBuilder);
Manual sportsCarManual = sportsCarManualBuilder.GetResult();
Console.WriteLine($"Sports CarManual: {sportsCarManual.SeatInstructions}, {sportsCarManual.EngineInstructions}, {sportsCarManual.TripComputerInstructions}, {sportsCarManual.GPSInstructions}");


// Build an SUV Var
RealCarBuilder SuvCarBuilder = new RealCarBuilder();
director.MakeSuv(SuvCarBuilder);
Car suvCar = SuvCarBuilder.GetResult();
Console.WriteLine($"SUV Car: Seats={suvCar.Seats}, Engine={suvCar.Engine}, GPS={suvCar.HasGPS}, TripComputer={suvCar.HasTripComputer}");

// Build a Manual for SUV Car
CarManualBuilder suvCarManualBuilder = new CarManualBuilder();
director.MakeSportsCar(suvCarManualBuilder);
Manual suvCarManual = suvCarManualBuilder.GetResult();
Console.WriteLine($"SUV Manual: {suvCarManual.SeatInstructions}, {suvCarManual.EngineInstructions}, {suvCarManual.TripComputerInstructions}, {suvCarManual.GPSInstructions}");
