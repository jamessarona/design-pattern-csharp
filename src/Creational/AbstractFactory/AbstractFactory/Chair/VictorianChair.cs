namespace AbstractFactory.Chair;

class VictorianChair : IChair
{
    public bool HasLegs()
    {
        return true;
    }

    public void SitOn()
    {
        Console.WriteLine("Sitting on a Victorian chair.");
    }
}