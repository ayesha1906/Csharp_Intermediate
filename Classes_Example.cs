using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}" , to,Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;

        }
    }
    class Classes_Example
    {
        static void Main(string[] args)
        {
            /* here we need to create person object which calls the method Parse and then the method itself returns another object 
             * which is required to call inroduce method . Hence to avoid this we can createstatic method to avoid creation of object 
             * and access the method directly through class .
             
             */

            //var per = new Person();
            var p =Person.Parse("John");
            p.Introduce("Ayesha");
        }
    }
}
