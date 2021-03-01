using Bridge.RemoteControl;

namespace Bridge.Televisor
{
    public class NewTelevisor : ITelevisor
    {
        public void SetRemoteControl(IRemoteControl remoteControl)
        {
            this.remoteControl = remoteControl;
        }

        public void On()
        {
            remoteControl.SendSignal("Turn on new TV");
        }

        public void Off()
        {
            remoteControl.SendSignal("Turn off new TV");
        }

        IRemoteControl remoteControl;
    }
}
