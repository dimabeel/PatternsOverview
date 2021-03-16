using System;
using System.Collections.Generic;
using System.Threading;

namespace Memento
{
    public class EditorCareTaker
    {
        public EditorCareTaker(Editor editor)
        {
            this.editor = editor;
            mementoHistory = new Stack<IMemento>();
        }

        public void SaveState()
        {
            Console.WriteLine("Saving state..");
            IMemento memento = editor.Save();
            mementoHistory.Push(memento);
        }

        public void Undo()
        {
            Console.WriteLine("Restoring state...");
            IMemento memento = mementoHistory.Pop();
            editor.Restore(memento);
        }

        public void ShowHistory()
        {
            Console.WriteLine("Memento's history:");
            foreach(var memento in mementoHistory)
            {
                Console.WriteLine(memento.GetState());
            }
        }

        Editor editor;
        Stack<IMemento> mementoHistory;
    }
}
