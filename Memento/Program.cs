namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor(" ");

            editor.Content = "The Matrix";
            editor.Save();

            editor.Content = "Mr. Robot";
            editor.Save();

            editor.Content = "Pirates of the Silicon Valley";
            editor.Undo();
            editor.Undo();
            editor.Content = "Do your best move!";
            editor.Save();
            editor.Undo();
        }
    }
}