using System;

namespace Memento
{
    public class Editor
    {
        public string Content { get; set; }
        public History History { get; set; } = new History();

        public Editor(string content)
        {
            Content = content;
            Save();
        }
        
        private EditorState CurrentState()
        {
            return new(Content);
        }

        private void RestoreTo(EditorState estate)
        {
            Content = estate?.Content;
        }

        public void Save()
        {
            History.SaveCurrentState(CurrentState());
            Console.WriteLine(Content);
        }

        public void Undo()
        {
            RestoreTo(History.Remove());
            Console.WriteLine(Content);
        }
    }
}