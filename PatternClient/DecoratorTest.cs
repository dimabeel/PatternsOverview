using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator;

namespace PatternClient
{
    class DecoratorTest
    {
        public void Work()
        {
            var firstCase = new DefaultBirdNotifier();
            firstCase.Notify();

            INotifier secondCase = new SMSNotifier(firstCase);
            secondCase = new EmailNotifier(secondCase);
            secondCase = new SlackNotifier(secondCase);
            secondCase = new VKNotifier(secondCase);
            secondCase.Notify();
        }
    }
}
