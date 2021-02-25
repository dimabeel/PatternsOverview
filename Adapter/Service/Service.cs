using System;

namespace Adapter.Service
{
    public class Service : IService
    {
        public void DoSomeWork(char[] serviceData)
        {
            Console.WriteLine("I'm service and I'm doing some work.");
            Console.WriteLine($"HashTag: #{serviceData.GetHashCode()}");
            Console.WriteLine($"ReceivedData: {new string(serviceData)}");
        }
    }
}
