using System;

namespace Decorator
{
    public class VKNotifier : INotifier
    {
        public VKNotifier(INotifier notifierDecorator)
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
