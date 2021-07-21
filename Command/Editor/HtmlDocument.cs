using System;

namespace Command.Editor
{
    public class HtmlDocument
    {
        public string Content { get; set; }

        public void WriteContentToConsole()
        {
            Console.WriteLine(Content);
        }
        
        public void MakeBold()
        {
            Content = "<b>" + Content + "</b>";
        }
    }
}