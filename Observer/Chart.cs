using System;
using System.Collections.Generic;

namespace Observer
{
    public class Chart : IObserver
    {
        public void Reload(IEnumerable<int> values)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"From {nameof(Chart)}. Values are updated: {string.Join(", ", values)}");
            Console.ResetColor();
        }
    }
}