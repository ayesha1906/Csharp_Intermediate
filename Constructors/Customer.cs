using System;
using System.Collections.Generic;

namespace Constructors
{
    class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            :this()               
            /* using this() it will pass the contents of the above const i.e we do not need to initialize 
             * the Orders List again in this constructor. This will reduce repetitions of lines*/

        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
           // this.Id = id;        because calling the above const with id parameter using this ()
            this.Name = name;
        }
    }
}
