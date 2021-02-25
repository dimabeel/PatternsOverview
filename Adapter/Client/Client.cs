using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Client
{
    public class Client : IClient
    {
        public Client(Service.IService service)
        {
            this.service = service;
        }

        public void WorkWithService()
        {
            Console.WriteLine("I'm client and I'm working with service");
            IClient adapter = new ClientServiceAdapter(service);
            adapter.WorkWithService();
        }

        private Service.IService service;
    }
}
