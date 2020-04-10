using System;

namespace Methods_Example
{
    
    class Methods
    {
        static void Main(string[] args)
        {
            Methods.UsePoints();
            Methods.UseParams();
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));

        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                // point.Move(null); causes exception
                Console.WriteLine("Point is at {0}, {1} ", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at {0}, {1} ", point.X, point.Y);

            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error ocurred");
            }

        }
    }
}
