using System;
using Command.Application;
using Command.Application.Commands;
using Command.Editor;
using Command.Framework;
using Command.Photoshop;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // normal command pattern
            var customerService = new CustomerService();
            var command = new AddCustomerCommand(customerService);
            var button = new Button(command) {Label = "Add Customer"};
            button.Click();
            
            // composite command example
            var composite = new CompositeCommand();
            composite.AddCommand(new ResizeCommand());
            composite.AddCommand(new BlackAndWhiteCommand());
            composite.Execute();
            
            // undoable command example
            var history = new History();
            var document = new HtmlDocument {Content = "devvhale"};
            var boldCommand = new MakeBoldCommand(history, document);
            document.WriteContentToConsole();
            
            boldCommand.Execute();
            document.WriteContentToConsole();
            
            // instead of writing undo logic like that use code below
            // boldCommand.UnExecute();
            // document.WriteContentToConsole();

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            document.WriteContentToConsole();
        }
    }
}