using Bridge.RemoteControl;

namespace Bridge.Televisor
{
    public class OldTelevisor : ITelevisor
    {
        public void SetRemoteControl(IRemoteControl remoteControl)
        {
            this.remoteControl = remoteControl;
        }

        public void On()
        {
            remoteControl.SendSignal("Turn on old TV");
        }

        public void Off()
        {
            remoteControl.SendSignal("Turn off old TV");
        }

        IRemoteControl remoteControl;
    }
}
