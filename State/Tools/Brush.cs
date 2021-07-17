using System;

namespace State.Tools
{
    public class Brush : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Start drawing a brushed line (brush-icon)");
        }

        public void MouseUp()
        {
            Console.WriteLine("Finish drawing a brushed line (brush-icon)");
        }
    }
}