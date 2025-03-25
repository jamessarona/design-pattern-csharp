using VideoConverterProject.Facade;

VideoConverter converter = new VideoConverter();

Console.WriteLine("Converting to MPEG4...");
converter.ConvertVideo("example.ogg", "mp4");

Console.WriteLine("\nConverting to OGG...");
converter.ConvertVideo("example.mp4", "ogg");