using System;

namespace State
{
    public class FirstState : IState
    {
        public void SetContext(IContext context)
        {
            this.context = context;
        }

        public void DoSomething()
        {
            Console.WriteLine("First state is doing something");
        }

        public void DoSomething1()
        {
            Console.WriteLine("First state is doing something 1");
            ChangeStateToSecond();
        }

        private void ChangeStateToSecond()
        {
            context.SetState(new SecondState());
            Console.WriteLine("Context has been changed state to second");
        }

        IContext context;
    }
}
