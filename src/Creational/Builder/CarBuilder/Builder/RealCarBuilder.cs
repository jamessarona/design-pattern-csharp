using CarBuilder.Model;

namespace CarBuilder.Builder;

public class RealCarBuilder : ICarBuilder
{
    private Car _car;

    public RealCarBuilder()
    {
        _car = new Car();
    }

    public void Reset()
    {
        _car = new Car();
    }

    public void SetEngine(string engine)
    {
        _car.Engine = engine;
    }

    public void setGps()
    {
        _car.HasGPS = true;
    }

    public void SetSeats(int number)
    {
        _car.Seats = number;
    }

    public void setTripComputer()
    {
        _car.HasTripComputer = true;
    }

    public Car GetResult()
    {
        return _car;
    }
}
