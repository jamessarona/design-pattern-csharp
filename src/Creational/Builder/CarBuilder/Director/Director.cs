using CarBuilder.Builder;

namespace CarBuilder.Director;

public class Director
{
    public void MakeSportsCar(ICarBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(2);
        builder.SetEngine("Sport Engine");
        builder.setTripComputer();
        builder.setGps();
    }

    public void MakeSuv(ICarBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(5);
        builder.SetEngine("SUV Engine");
        builder.setGps();
    }
}
