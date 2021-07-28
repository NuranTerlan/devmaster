using System.Collections.Generic;
using System.Threading;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataSource(new List<IObserver> {new Chart(), new SpreadSheet()});

            for (int i = 1; i < 20; i += 2)
            {
                ds.AddValue(i);
                Thread.Sleep(1000);
            }
        }
    }
}