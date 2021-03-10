using System;

namespace State
{
    public class Context : IContext
    {
        public Context(IState state)
        {
            this.state = state;
            this.state.SetContext(this);
        }

        public void SetState(IState state)
        {
            this.state = state;
            this.state.SetContext(this);
            Console.WriteLine("The state in context has been changed");
        }

        public void DoSomething()
        {
            state.DoSomething();
        }

        public void DoSomething1()
        {
            state.DoSomething1();
        }

        IState state;
    }
}
