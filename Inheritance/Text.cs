using System;

namespace Inheritance_Example
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        

        public void AddHyperLink(string url)
        {
            Console.WriteLine(Height);
           Console.WriteLine("We added a link to " +url);
        }
    }
}
