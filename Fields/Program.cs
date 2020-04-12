using System;
using System.Collections.Generic;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);  //display 2

            customer.Promote();

            /* now will display 0 since due to calling promote method our list is initialized again .
             * So all of the data is lost.     
             * Thus we can use readonly  modifier to make sure that we can initialise our field only once
             * */
            Console.WriteLine(customer.Orders.Count); //0


        }
    }
}
