using System;
using Memento;

namespace PatternClient
{
    public class MementoTest
    {
        public void Work()
        {
            var editor = new Editor("Hello");
            var careTaker = new EditorCareTaker(editor);
            editor.ShowCurrentState();
            careTaker.SaveState();

            editor.WriteSomething("I'm software developer");
            careTaker.SaveState();

            editor.WriteSomething("You have to forgot this message");
            editor.WriteSomething("And this one");
            editor.WriteSomething("Save this pls message");
            careTaker.SaveState();

            Console.WriteLine();
            careTaker.ShowHistory();
            Console.WriteLine();

            careTaker.Undo();
            editor.ShowCurrentState();
            careTaker.Undo();
            editor.ShowCurrentState();
            careTaker.Undo();
            editor.ShowCurrentState();
        }
    }
}