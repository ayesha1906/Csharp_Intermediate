using System;

namespace MultipleInheritance
{
    public class TextBox : UiControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            Console.WriteLine("shape dragged");
        }

        public void Drop()
        {
            Console.WriteLine("Shape dropped.");
        }
    }
}
