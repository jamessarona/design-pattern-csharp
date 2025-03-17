using SquareToRound.Round;

namespace SquareToRound.Square;

public class SquarePegAdapter : RoundPeg
{
    private SquarePeg peg;
    public SquarePegAdapter(SquarePeg peg) 
        : base(peg.GetWidth() * Math.Sqrt(2) / 2)
    {
        this.peg = peg;
    }
}