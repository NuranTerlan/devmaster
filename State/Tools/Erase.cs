using System;

namespace State.Tools
{
    public class Erase : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Start erasing a dashed line (erase-icon)");
        }

        public void MouseUp()
        {
            Console.WriteLine("Finish erasing a dashed line (erase-icon)");
        }
    }
}