using System;

namespace Facade
{
    public interface ISystem2
    {
        void DoFifthTask();

        void DoSixthTask();
    }

    public class System2 : ISystem2
    {
        public void DoFifthTask()
        {
            Console.WriteLine("System 2 done fifth task");
        }

        public void DoSixthTask()
        {
            Console.WriteLine("System 2 done sixth task");
        }
    }
}
