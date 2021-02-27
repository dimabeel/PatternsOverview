using System;

namespace Decorator
{
    public class EmailNotifier : INotifier
    {
        public EmailNotifier(INotifier notifierDecorator)
        {
            this.notifierDecorator = notifierDecorator;
        }

        public void Notify()
        {
            notifierDecorator.Notify();

            Console.WriteLine("Sent Email notification");
        }

        INotifier notifierDecorator;
    }
}
