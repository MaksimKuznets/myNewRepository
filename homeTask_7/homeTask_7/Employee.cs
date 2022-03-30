using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_7
{
    abstract class Employee: Person
    {
        public Employee(string name, string lastName, int taxId) : base(name, lastName, taxId)
        {

        }
        public string GetEmployee() 
        {
            return ($"{this.Name} {this.LastName} {this.TaxId}");
        }
    }
}
