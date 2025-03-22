using NotificationLibrary.Base;
using NotificationLibrary.Decorators;

// Base notifier
INotifier notifier = new Notifier();

// Adding Email Notifier
notifier = new EmailNotifier(notifier);

// Adding SMS Notifier
notifier = new SMSNotifier(notifier);

// Adding Slack Notifier
notifier = new SlackNotifier(notifier);

// Sending Notification
notifier.Send("Alert!");