using System;
using System.Threading;
using Strategy.Compressors;
using Strategy.Filters;

namespace Strategy
{
    public class ImageStorage
    {
        public IFilter Filter { get; private set; }
        public ICompressor Compressor { get; private set; }
        
        public void Store(string url, CompressMethods compressMethod, FilterMethods filterMethod)
        {
            SetCompressMethod(compressMethod);
            SetFilterMethod(filterMethod);
            
            Thread.Sleep(650);
            Compressor.Compress();
            Thread.Sleep(650);
            Filter.Apply();
            Thread.Sleep(300);
            Console.WriteLine($"The image@{url} is stored..");
        }

        private void SetFilterMethod(FilterMethods methods)
        {
            Filter = methods switch
            {
                FilterMethods.BlackAndWhite => new BlackAndWhiteFilter(),
                FilterMethods.HighContrast => new HighContrastFilter(),
                _ => throw new ArgumentOutOfRangeException(nameof(methods), methods, null)
            };
        }

        private void SetCompressMethod(CompressMethods methods)
        {
            Compressor = methods switch
            {
                CompressMethods.Jpeg => new JpegCompressor(),
                CompressMethods.Png => new PngCompressor(),
                _ => throw new ArgumentOutOfRangeException(nameof(methods), methods, null)
            };
        }
    }
}