using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade;

namespace PatternClient
{
    public class FacadeTest
    {
        public void Work()
        {
            ISystem1 system1 = new System1();
            ISystem2 system2 = new System2();
            var facade = new SystemFacade(system1, system2);

            facade.RunAllTasks();
        }
    }
}
