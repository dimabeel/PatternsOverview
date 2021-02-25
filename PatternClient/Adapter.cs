using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Service;
using Adapter.Client;

namespace PatternClient
{
    class AdapterTest
    {
        public void Work()
        {
            IService service = new Service();
            IClient client = new Client(service);
            client.WorkWithService();
        }
    }
}
