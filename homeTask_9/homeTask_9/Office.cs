using System;
using System.Collections.Generic;
using System.Text;

namespace homeTask_9
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

        public void GetOffice()
        {
            foreach(Employee item in this.employees)
            {
                Console.WriteLine($"{item.GetEmployee()}");
            }
        }

       

    }
}
