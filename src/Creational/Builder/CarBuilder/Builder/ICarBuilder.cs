namespace CarBuilder.Builder;

public interface ICarBuilder
{
    void Reset();
    void SetSeats(int Bumber);
    void SetEngine(string Engine);
    void setTripComputer();
    void setGps();
}