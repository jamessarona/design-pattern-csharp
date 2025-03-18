using SampleComposite;

// Create leaf components
IComponent leaf1 = new Leaf();
IComponent leaf2 = new Leaf();

// Create composite and add leaf components
Composite composite = new Composite();
composite.Add(leaf1);
composite.Add(leaf2);

// Execute the composite (which delegates to children)
composite.Execute();