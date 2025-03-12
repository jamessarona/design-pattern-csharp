using Factory;
using System.Diagnostics;

ITransport transport;

transport = new Truck();

// Execute the deliver method
transport.Deliver();


transport = new Ship();

// Execute the deliver method
transport.Deliver();