using System;

namespace Strategy.Filters
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply()
        {
            Console.WriteLine("Black&White filter is applied to the image.");
        }
    }
}