using System;

namespace Facade
{
    public interface ISystem1
    {
        void DoFirstTask();

        void DoSecondTask();
    }

    public class System1 : ISystem1
    {
        public void DoFirstTask()
        {
            Console.WriteLine("System 1 done first task");
        }

        public void DoSecondTask()
        {
            Console.WriteLine("System 1 done second task");
        }
    }
}
