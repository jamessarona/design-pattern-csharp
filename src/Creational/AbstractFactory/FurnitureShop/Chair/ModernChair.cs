namespace AbstractFactory.Chair
{
    class ModernChair : IChair
    {
        public bool HasLegs()
        {
            return true;
        }

        public void SitOn()
        {
            Console.WriteLine("Sitting on a Modern chair.");
        }
    }
}
