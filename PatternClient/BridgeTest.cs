using System;
using Bridge.Televisor;
using Bridge.RemoteControl;

namespace PatternClient
{
    public class BridgeTest
    {
        public void Work()
        {
            ITelevisor oldTV = new OldTelevisor();
            oldTV.SetRemoteControl(new OldRemoteControl());
            oldTV.On();
            Console.WriteLine("Still working...");
            oldTV.Off();

            Console.WriteLine();Console.WriteLine();

            ITelevisor newTV = new NewTelevisor();
            newTV.SetRemoteControl(new NewRemoteControl());
            newTV.On();
            Console.WriteLine("Working more fast...");
            newTV.Off();

            Console.WriteLine();Console.WriteLine();

            var oldTvRemotedByNewRemote = new OldTelevisor();
            oldTvRemotedByNewRemote.SetRemoteControl(new NewRemoteControl());
            oldTvRemotedByNewRemote.On();
            Console.WriteLine("Good legacy support! It's still working");
            oldTvRemotedByNewRemote.Off();
        }
    }
}
