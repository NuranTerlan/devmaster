using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var browseHistory = new BrowseHistory();
            browseHistory.Push("www.google.com");
            browseHistory.Push("www.simbrella.com");
            browseHistory.Push("www.hub.docker.com");
            var iterator = browseHistory.GetIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.GetCurrent());
                iterator.Next();
            }
            
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.GetCurrent());
                iterator.Next();
            }
        }
    }
}