using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_9
{
    class Person
    {
        public string Name{get; }
        public string LastName { get; }

        public Person(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }
    }
}
