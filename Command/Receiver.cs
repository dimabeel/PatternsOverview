using System;

namespace Command
{
    public interface IReceiver
    {
        bool Open();

        bool PrintMessage(string message);

        bool Close();
    }

    public class Receiver : IReceiver
    {
        public Receiver()
        {
            alreadySaved = false;
            opened = false;
        }

        public bool Open()
        {
            if (!Opened)
            {
                Console.WriteLine("Open command");
                opened = true;
                return true;
            }

            return false;
        }

        public bool PrintMessage(string message)
        {
            if (Opened)
            {
                Console.WriteLine($"Receiver printed message: {message}");
                return true;
            }

            return false;
        }

        public bool Close()
        {
            if (Opened)
            {
                Console.WriteLine("Close command");
                opened = false;
                return true;
            }

            return false;
        }

        public bool Opened
        {
            get
            {
                return opened;
            }
        }

        public bool AlreadySaved
        {
            get
            {
                return alreadySaved;
            }
        }

        bool opened;
        bool alreadySaved;
    }
}