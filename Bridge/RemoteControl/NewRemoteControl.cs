using System;

namespace Bridge.RemoteControl
{
    public class NewRemoteControl : IRemoteControl
    {
        public void SendSignal(string signalMessage)
        {
            Console.WriteLine($"New remote control did task: {signalMessage}");
        }
    }
}
