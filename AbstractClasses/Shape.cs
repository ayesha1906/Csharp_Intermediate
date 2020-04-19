using System;
namespace AbstractClasses
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        /*
        public  void Draw()
        {
         if we keep this method as not abstract then the draw method from rect class would not 
         do any implementation. Hence for the developer to implement this method we can make it as abstract.

        }
        */

        public abstract void Draw();

      public void Cope()
        {
            Console.WriteLine("Copied Shape into clipboard");
        }

        public void Select()
        {
            Console.WriteLine("Select the Shape.");
        }
    }
}
