using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class DefaultBirdNotifier : INotifier
    {
        public void Notify()
        {
            Console.WriteLine("Sent notification by bird");
        }
    }
}
