using System;

namespace Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Height = 500;

            text.Copy();
            text.AddHyperLink("www.google.com");


        }
    }
}
