using System;

namespace Command
{
    public interface IInvoker
    {
        void WriteInFile(string text);
    }

    public class Invoker : IInvoker
    {
        public Invoker(ICommand openCommand, ICommand closeCommand)
        {
            this.openCommand = openCommand;
            this.closeCommand = closeCommand;
        }

        public void WriteInFile(string text)
        {
            openCommand.RunCommand();
            Console.WriteLine($"Writing in file: {text}.");
            closeCommand.RunCommand();
        }

        ICommand openCommand;
        ICommand closeCommand;
    }
}