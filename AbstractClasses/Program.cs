using System.Collections.Generic;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
           // var shape = new Shape(); //error since it is abstract

            var circle = new Circle();
            circle.Draw();

            var rect = new Rectangle();
            rect.Draw();

        }
    }
}
