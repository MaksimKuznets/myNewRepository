using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_7
{
    abstract class Employee: Person
    {
        public string Fullname { get; set; } 
        public Employee(string name, string lastName, int taxId) : base(name, lastName, taxId)
        {
            this.Fullname = name + " " + lastName;
        }
        public string GetEmployee() 
        {
            return ($"{this.Name} {this.LastName} {this.TaxId}");
        }
    }
}
