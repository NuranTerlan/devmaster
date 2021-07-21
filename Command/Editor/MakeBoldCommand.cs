namespace Command.Editor
{
    public class MakeBoldCommand : IUndoableCommand
    {
        public string PrevContent { get; set; }
        public History History { get; }
        public HtmlDocument Document { get; }

        public MakeBoldCommand(History history, HtmlDocument document)
        {
            History = history;
            Document = document;
        }
        
        public void Execute()
        {
            PrevContent = Document.Content;
            Document.MakeBold();
            History.Push(this);
        }

        public void UnExecute()
        {
            Document.Content = PrevContent;
        }
    }
}