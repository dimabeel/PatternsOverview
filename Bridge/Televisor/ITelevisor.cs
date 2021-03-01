using Bridge.RemoteControl;

namespace Bridge.Televisor
{
    public interface ITelevisor
    {
        public void SetRemoteControl(IRemoteControl remoteControl);

        public void On();

        public void Off();
    }
}
