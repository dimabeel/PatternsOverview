using System;

namespace Bridge.RemoteControl
{
    public interface IRemoteControl
    {
        public void SendSignal(string signalMessage);
    }
}
