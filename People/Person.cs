using System;

namespace People
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }

        public string GetNameComplete() => string.Concat(Name, " ", Surname);
        

    }
}
