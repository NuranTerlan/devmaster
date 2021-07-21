namespace Command.Editor
{
    public interface ICommand
    {
        History History { get; }
        void Execute();
    }
}