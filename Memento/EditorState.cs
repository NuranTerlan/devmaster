namespace Memento
{
    public class EditorState
    {
        public string Content { get; init; }

        public EditorState(string content)
        {
            Content = content;
        }
    }
}