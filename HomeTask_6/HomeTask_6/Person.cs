using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_6
{
    class Person
    {
        public string Name { get; set; } = "";
        public string Lastname { get; set; } = "";

        public Person(string _name, string _lastname)
        {
            this.Name = _name;
            this.Lastname = _lastname;
        }
      
    }
}
