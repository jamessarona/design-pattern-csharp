﻿using NotificationLibrary.Base;

namespace NotificationLibrary.Decorators;

public class SlackNotifier : NotifierDecorator
{
    public SlackNotifier(INotifier notifier) : base(notifier) { }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Slack Notification Sent: {message}");
    }
}