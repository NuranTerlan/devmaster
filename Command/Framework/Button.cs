using System;

namespace Command.Framework
{
    public class Button
    {
        public string Label { get; set; }

        private readonly ICommand _command;

        public Button(ICommand command)
        {
            _command = command;
        }

        public void Click()
        {
            Console.Write(Label + " button is clicked | ");
            _command.Execute();
        }
    }
}