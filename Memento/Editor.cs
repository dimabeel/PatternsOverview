using System;
using System.Collections.Generic;
using System.Threading;

namespace Memento
{
    public class Editor
    {
        public Editor(string defaultState)
        {
            this.state = defaultState;
        }

        public void WriteSomething(string something)
        {
            string message = $"{something}. Date:{DateTime.Now}";
            Console.WriteLine(message);
            state = message;
            Thread.Sleep(1500);
        }

        public IMemento Save()
        {
            return new EditorMemento(state);
        }

        public void Restore(IMemento memento)
        {
            if (memento is EditorMemento m)
            {
                state = m.GetState();
            }
        }

        public void ShowCurrentState()
        {
            Console.WriteLine(state);
        }

        string state;
    }
}
