using Factory;

ITransport transport;

transport = new Truck();

// Execute the deliver method
transport.Deliver();


transport = new Ship();

// Execute the deliver method
transport.Deliver();