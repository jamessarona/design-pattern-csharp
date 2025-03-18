using ImageEditorComposite;

ImageEditor editor = new ImageEditor();

// Load objects
editor.Load();

// Draw all graphics
editor.Draw();

// Move graphics
editor.Move(2, 3);

// Redraw after moving
editor.Draw();