using System;

namespace Properties
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1998, 7, 1));
            Console.WriteLine(person.Age);
        }
    }
}
