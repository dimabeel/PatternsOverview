using System;
using System.Collections.Generic;
using System.Threading;

namespace Memento
{
    public class EditorMemento : IMemento
    {
        public EditorMemento(string editorState)
        {
            state = editorState;
        }

        public string GetState()
        {
            return state;
        }

        string state;
    }
}
