using SquareToRound.Round;
using SquareToRound.Square;

RoundHole hole = new RoundHole(5);
RoundPeg roundPeg = new RoundPeg(5);
Console.WriteLine($"Round peg fits: {hole.Fits(roundPeg)}"); // True

SquarePeg smallSquarePeg = new SquarePeg(5);
SquarePeg largeSquarePeg = new SquarePeg(10);

SquarePegAdapter smallAdapter = new SquarePegAdapter(smallSquarePeg);
SquarePegAdapter largeAdapter = new SquarePegAdapter(largeSquarePeg);

Console.WriteLine($"Small square peg fits: {hole.Fits(smallAdapter)}"); // True
Console.WriteLine($"Large square peg fits: {hole.Fits(largeAdapter)}"); // False

Console.ReadLine();