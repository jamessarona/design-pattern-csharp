﻿namespace Factory;

public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Deliver by land in a box.");
    }
}