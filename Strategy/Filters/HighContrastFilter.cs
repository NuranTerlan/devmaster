using System;

namespace Strategy.Filters
{
    public class HighContrastFilter : IFilter
    {
        public void Apply()
        {
            Console.WriteLine("High contrast filter is applied to the image.");
        }
    }
}