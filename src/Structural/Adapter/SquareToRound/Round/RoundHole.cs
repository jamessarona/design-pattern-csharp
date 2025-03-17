namespace SquareToRound.Round;

public class RoundHole
{
    private double radius;

    public RoundHole(double radius)
    {
        this.radius = radius;
    }

    public double GetRadius()
    {
        return radius;
    }

    public bool Fits(RoundPeg peg)
    {
        return peg.GetRadius() <= radius;
    }
}
