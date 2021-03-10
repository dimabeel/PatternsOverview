using System;
using State;

namespace PatternClient
{
    public class StateTest
    {
        public void Work()
        {
            IState firstState = new FirstState();
            IContext context = new Context(firstState);

            for(int i = 0; i < 4; i++)
            {
                context.DoSomething();
                context.DoSomething1();
                Console.WriteLine();
            }

            IState secondState = new SecondState();
            context.SetState(secondState);
            context.DoSomething();
            context.DoSomething1();
        }
    }
}