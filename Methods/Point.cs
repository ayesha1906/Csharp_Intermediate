using System;

namespace Methods_Example
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;

        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /*
        public void Move(Point newLocation)
        {
            this.X = newLocation.X;
            this.Y = newLocation.Y;

        }
        */

       // To avoid repetition of lines of code we can use the below method :
        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }
    }
}
