namespace NotificationLibrary.Base;

public class Notifier : INotifier
{
    public virtual void Send(string message)
    {
        Console.WriteLine($"Base Notifier: {message}");
    }
}