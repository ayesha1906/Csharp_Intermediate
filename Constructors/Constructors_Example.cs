using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Order
    {

    }
   
    class Constructors_Example
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Ayesha");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine();

            var cust = new Customer(1);
            Console.WriteLine(cust.Id);
            Console.WriteLine(cust.Name);

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


        }
    }
}
