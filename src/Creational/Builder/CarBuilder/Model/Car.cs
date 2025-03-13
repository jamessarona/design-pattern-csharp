namespace CarBuilder.Model;

public class Car
{
    public int Seats { get; set; } = default!;
    public string Engine { get; set; } = default!;
    public bool HasTripComputer { get; set; } = default!;
    public bool HasGPS { get; set; } = default!;
}