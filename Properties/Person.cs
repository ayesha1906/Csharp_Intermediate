using System;

namespace Properties
{
    public class Person
    {
        public Person(DateTime birthdate)
        {
            Birthhdate = birthdate;
        }
        public DateTime Birthhdate { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthhdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}