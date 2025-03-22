using NotificationLibrary.Base;

namespace NotificationLibrary.Decorators;

public class SMSNotifier : NotifierDecorator
{
    public SMSNotifier(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"SMS Notification Sent: {message}");
    }
}
