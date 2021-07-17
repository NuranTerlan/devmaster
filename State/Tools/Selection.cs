using System;

namespace State.Tools
{
    public class Selection : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Start drawing a dashed line (selection-icon)");
        }

        public void MouseUp()
        {
            Console.WriteLine("Finish drawing a dashed line (selection-icon)");
        }
    }
}