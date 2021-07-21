using System;

namespace Command.Photoshop
{
    public class BlackAndWhiteCommand : IPhotoshopCommand
    {
        public void Execute()
        {
            Console.WriteLine("Applying black&white filter to image..");
        }
    }
}