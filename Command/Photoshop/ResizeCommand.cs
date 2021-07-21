using System;

namespace Command.Photoshop
{
    public class ResizeCommand : IPhotoshopCommand
    {
        public void Execute()
        {
            Console.WriteLine("Resizing image..");
        }
    }
}