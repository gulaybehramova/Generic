using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

    }
}
