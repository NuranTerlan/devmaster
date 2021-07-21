using System.Collections.Generic;

namespace Command.Editor
{
    public class History
    {
        private readonly Stack<IUndoableCommand> _commands;

        public History()
        {
            _commands = new Stack<IUndoableCommand>();
        }

        public void Push(IUndoableCommand command)
        {
            _commands.Push(command);
        }

        public IUndoableCommand Pop()
        {
            return _commands.Pop();
        }

        public bool IsEmpty() => _commands.Count == 0;
    }
}