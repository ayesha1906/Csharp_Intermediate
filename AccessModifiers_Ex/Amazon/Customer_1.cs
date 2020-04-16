
using System;

namespace Amazon
{
    public class Customer_1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote1()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
            Console.WriteLine("promote Logic Changed.");
        }

       
    }
}
