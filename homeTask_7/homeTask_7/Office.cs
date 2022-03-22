using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_7
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
        }
        public void AddEmployees(Employee[] newEmployee)
        {
            this.employees.AddRange(newEmployee);
        }

       

    }
}
