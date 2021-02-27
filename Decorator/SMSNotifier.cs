using System;

namespace Decorator
{
    public class SMSNotifier : INotifier
    {
        public SMSNotifier(INotifier notifierDecorator)
        {
            this.notifierDecorator = notifierDecorator;
        }

        public void Notify()
        {
            notifierDecorator.Notify();

            Console.WriteLine("Sent SMS notification");
        }

        INotifier notifierDecorator;
    }
}
