using System;
using System.Collections.Generic;

namespace Memento
{
    public class History
    {
        public Stack<EditorState> StateHistory { get; set; } = new Stack<EditorState>();

        public void SaveCurrentState(EditorState estate)
        {
            StateHistory.Push(estate);
        }

        public EditorState Remove()
        {
            var canBePopped = StateHistory.TryPop(out var poppedState);

            if (canBePopped) return StateHistory.TryPeek(out var afterUndo) ? afterUndo : null;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Can't undo the editor's content, because you are at the very first state");
            Console.ResetColor();
            return null;
        }
    }
}