using System;
using System.Linq;

namespace Proxy
{
    public class SummorizeServer : ISummorizeServer
    {
        public void SummArr(int[] arr)
        {
            Console.WriteLine($"Arr summ is: {arr.Sum()}");
        }
    }
}
