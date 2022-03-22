using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_8
{
    class Office
    {
       private List<Employee> employees = new List<Employee>();
        public List<Employee> Employees
        {
            get
            {
                return this.employees;
            }
            set
            {
                this.employees = value;
            }
        }
        public void AddEmployees(Employee[] newEmployee)
        {
            this.employees.AddRange(newEmployee);
        }

       

    }
}
