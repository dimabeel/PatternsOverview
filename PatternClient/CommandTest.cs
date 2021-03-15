using System;
using Command;

namespace PatternClient
{
    public class CommandTest
    {
        public void Work()
        {
            IReceiver receiver = new Receiver();

            ICommand openCommand = new OpenCommand(receiver);
            ICommand closeCommand = new CloseCommand(receiver);
            IInvoker invoker = new Invoker(openCommand, closeCommand);

            invoker.WriteInFile("Blya blya blya");
            invoker.WriteInFile("Wurp wurp wurp");

        }
    }
}