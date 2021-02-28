using System.Linq;
using Proxy;

namespace PatternClient
{
    public class ProxyTest
    {
        public void Work()
        {
            var arrForSum = Enumerable.Range(1, 30).ToArray();

            ISummorizeServer summorizeServer = new SummorizeServer();
            summorizeServer.SummArr(arrForSum);

            ISummorizeServer proxyServer =
                new SummorizeServerProxy(summorizeServer);
            proxyServer.SummArr(arrForSum);
        }
    }
}
