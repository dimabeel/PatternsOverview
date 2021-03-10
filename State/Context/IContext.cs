using System;

namespace State
{
    public interface IContext
    {
        void SetState(IState state);

        void DoSomething();

        void DoSomething1();
    }
}
