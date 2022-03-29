using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_9
{
    abstract class Employee: Person
    {
        public int TaxId { get; private set; }
        public Employee(string name, string lastName, int taxid): base(name, lastName)
        {
            this.TaxId = taxid;
        }
        public string GetEmployee() 
        {
            return ($"{this.Name} {this.LastName} with TaxId = {this.TaxId}");
        }
    }
}
