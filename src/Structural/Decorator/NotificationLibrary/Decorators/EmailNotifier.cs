using NotificationLibrary.Base;

namespace NotificationLibrary.Decorators;

public class EmailNotifier : NotifierDecorator
{
    public EmailNotifier(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Email Notification Sent: {message}");
    }
}