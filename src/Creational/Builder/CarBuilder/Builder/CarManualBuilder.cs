using CarBuilder.Model;

namespace CarBuilder.Builder;

public class CarManualBuilder : ICarBuilder
{
    private Manual _manual;

    public CarManualBuilder()
    {
        _manual = new Manual();
    }

    public void Reset()
    {
        _manual = new Manual();
    }

    public void SetEngine(string engine)
    {
        _manual.EngineInstructions = $"Engine: {engine}";
    }

    public void setGps()
    {
        _manual.GPSInstructions = "GPS installed.";
    }

    public void SetSeats(int number)
    {
        _manual.SeatInstructions = $"Seats: {number}";
    }

    public void setTripComputer()
    {
        _manual.TripComputerInstructions = "Trip Computer installed.";
    }

    public Manual GetResult()
    {
        return _manual;
    }
}
