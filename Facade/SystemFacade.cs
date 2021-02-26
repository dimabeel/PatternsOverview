namespace Facade
{
    public class SystemFacade
    {
        public SystemFacade(ISystem1 system1, ISystem2 system2)
        {
            this.system1 = system1;
            this.system2 = system2;
        }

        public void RunAllTasks()
        {
            system1.DoFirstTask();
            system1.DoSecondTask();
            system2.DoFifthTask();
            system2.DoSixthTask();
        }

        ISystem1 system1;
        ISystem2 system2;
    }
}
