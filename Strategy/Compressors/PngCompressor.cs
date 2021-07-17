using System;

namespace Strategy.Compressors
{
    public class PngCompressor : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Image is compressed properly for png format.");
        }
    }
}