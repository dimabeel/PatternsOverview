using System;

namespace Decorator
{
    public class SlackNotifier : INotifier
    {
        public SlackNotifier(INotifier notifierDecorator)
        {
            this.notifierDecorator = notifierDecorator;
        }

        public void Notify()
        {
            notifierDecorator.Notify();

            Console.WriteLine("Sent Slack notification");
        }

        INotifier notifierDecorator;
    }
}
