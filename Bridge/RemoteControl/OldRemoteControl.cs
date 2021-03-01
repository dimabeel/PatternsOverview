using Bridge.RemoteControl;
using System;

namespace Bridge.RemoteControl
{
    public class OldRemoteControl : IRemoteControl
    {
        public void SendSignal(string signalMessage)
        {
            Console.WriteLine($"Old remote control did task: {signalMessage}");
        }
    }
}
