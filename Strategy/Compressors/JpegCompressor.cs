using System;

namespace Strategy.Compressors
{
    public class JpegCompressor : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Image is compressed properly for jpeg format.");
        }
    }
}