using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer
{
    public class SpreadSheet : IObserver
    {
        public void Reload(IEnumerable<int> values)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"From {nameof(SpreadSheet)}. Sum changed: {values.Sum()}");
            Console.ResetColor();
        }
    }
}