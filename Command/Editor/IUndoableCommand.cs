namespace Command.Editor
{
    public interface IUndoableCommand : Editor.ICommand
    {
        string PrevContent { get; set; }
        HtmlDocument Document { get; }
        void UnExecute();
    }
}