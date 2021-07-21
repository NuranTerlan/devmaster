using System;
using System.Collections.Generic;
using System.Linq;
using Command.Framework;

namespace Command.Photoshop
{
    public class CompositeCommand : ICommand
    {
        private readonly List<IPhotoshopCommand> _commands;

        public CompositeCommand()
        {
            _commands = new List<IPhotoshopCommand>();
        }

        public void AddCommand(IPhotoshopCommand command)
        {
            _commands.Add(command);
        }

        public void AddCommands(IEnumerable<IPhotoshopCommand> commands)
        {
            _commands.AddRange(commands);
        }

        public void Execute()
        {
            if (!_commands.Any())
            {
                Console.WriteLine("No command found in task execution pipeline!");
            }

            _commands.ForEach(c => c.Execute());
        }
    }
}