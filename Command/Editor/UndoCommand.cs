using System;

namespace Command.Editor
{
    public class UndoCommand : Editor.ICommand
    {
        public History History { get; }

        public UndoCommand(History history)
        {
            History = history;
        }

        public void Execute()
        {
            if (History.IsEmpty())
            {
                Console.WriteLine("Can't undo, because history is empty!");
                return;
            }

            History.Pop().UnExecute();
        }
    }
}