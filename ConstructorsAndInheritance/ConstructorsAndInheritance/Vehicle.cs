using System;


namespace ConstructorsAndInheritance
{
    public class Vehicle
    {
        protected readonly string _registerationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized.");
        //}


        public Vehicle(string registerationNumber)
        {
            _registerationNumber = registerationNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", registerationNumber);
        }
    }
}
