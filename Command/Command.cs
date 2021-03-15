namespace Command
{
    public interface ICommand
    {
        bool RunCommand();
    }

    public class OpenCommand : ICommand
    {
        public OpenCommand(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public bool RunCommand()
        {
            return receiver.Open();
        }

        IReceiver receiver;
    }

    public class PrintMessageCommand : ICommand
    {
        public PrintMessageCommand(string message, IReceiver receiver)
        {
            this.message = message;
            this.receiver = receiver;
        }

        public bool RunCommand()
        {
            return receiver.PrintMessage(message);
        }

        public string Message
        {
            get
            {
                return message;
            }
        }

        IReceiver receiver;
        string message;
    }

    public class CloseCommand : ICommand
    {
        public CloseCommand(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public bool RunCommand()
        {
            return receiver.Close();
        }

        IReceiver receiver;
    }
}
