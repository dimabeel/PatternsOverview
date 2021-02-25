using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class ClientServiceAdapter : Client.IClient
    {
        public ClientServiceAdapter(Service.IService service)
        {
            this.service = service;
        }

        public void WorkWithService()
        {
            service.DoSomeWork("Hey hey hey".ToCharArray());
        }

        Service.IService service;
    }
}
