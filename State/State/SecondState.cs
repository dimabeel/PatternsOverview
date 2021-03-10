using System;

namespace State
{
    public class SecondState : IState
    {
        public void SetContext(IContext context)
        {
            this.context = context;
        }

        public void DoSomething()
        {
            Console.WriteLine("Second state is doing something");
        }

        public void DoSomething1()
        {
            Console.WriteLine("Second state is doing something 1");
            ChangeStateToFirst();
        }

        private void ChangeStateToFirst()
        {
            context.SetState(new FirstState());
            Console.WriteLine("Context has been changed to first");
        }

        IContext context;
    }
}
