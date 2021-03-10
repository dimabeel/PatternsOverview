using System;

namespace State
{
    public interface IState
    {
        void SetContext(IContext context);

        void DoSomething();

        void DoSomething1();
    }
}
