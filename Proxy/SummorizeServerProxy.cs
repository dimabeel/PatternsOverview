using System;

namespace Proxy
{
    public class SummorizeServerProxy : ISummorizeServer
    {
        public SummorizeServerProxy(ISummorizeServer server)
        {
            this.server = server;
        }

        public void SummArr(int[] arr)
        {
            LogActivity();

            server.SummArr(arr);
        }

        public void LogActivity()
        {
            Console.WriteLine("The server has been calculating array elements sum!");
        }

        ISummorizeServer server;
    }
}
