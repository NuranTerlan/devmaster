namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.MouseDown();
            canvas.MouseUp();
            canvas.EnableTool(ToolNames.Brush);
            canvas.MouseDown();
            canvas.MouseUp();
            canvas.EnableTool(ToolNames.Erase);
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}