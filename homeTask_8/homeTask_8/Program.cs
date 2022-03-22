using System;
using System.Collections.Generic;
using homeTask_8.Comparators;

namespace homeTask_8
{
//Разработать классы для программы управления ИТ офисом.
//1. Класс Office содержит список Employee, сотрудники бывают QAEmployee, DevEmployee,
//BAEmployee, PMEmployee, QAAutomationEmployee, QAAutomationTeamLead, DevTEamLead, QATeamLead.
//2. Ассайнить таски могут тимлиды и PMEmployee, делать ревью кода тимлиды QAAutomation и Dev.
//3. Писать код могут Dev, QAAuto и их тимлиды.
//4. Заполнить список Employee специалистами разного профиля, и вывести подробную информацию
//о специлистах, которые могут
//4.1 писать код
//4.2 ассайнить таски
//4.3 делать ревью кода
    class Program
    {
        static void Main(string[] args)
        {
            BAEmployee BA = new BAEmployee("Ivan", "Kovalev", 4);
            DevEmployee Dev = new DevEmployee("Slava", "Rossiytsev", 55);
            DevTeamLead DevTL = new DevTeamLead("Maksim", "Medunitsa", 65);
            PMEmployee PM = new PMEmployee("Anastasia", "Bogdanova",1);
            QAAutomationEmployee QAAutomation = new QAAutomationEmployee("Yana","Grechikho",554);
            QAAutomationTeamLead QAutomationTL = new QAAutomationTeamLead("Alexander", "Savenok", 77);
            QAEmployee QA = new QAEmployee("Maksim", "Kuznets",69);
            QATeamLead QATL = new QATeamLead("Tatiana","Dubitskaya",123);
            Employee[] emp = { BA, Dev, DevTL, PM, QAAutomation, QAutomationTL, QA, QATL };
            
            Office office = new Office();
            
            office.AddEmployees(emp);
            Console.WriteLine("-----Sort AssigneTask by Name------");
            office.Employees.Sort(new AssigneTaskCompare());
            foreach (Employee item in office.Employees)
            {
                Console.Write($"{item.GetEmployee()}");
                if (item is IAssigner)
                {
                    Console.Write(" assigner\n");
                }
                else Console.Write("\n");
            }
            Console.WriteLine("-----Sort by Name------");
                        office.Employees.Sort(new FirstNameCompare());
            foreach (Employee item in office.Employees)
            {
                Console.Write($"{item.GetEmployee()}\n");
              
            }
            Console.WriteLine("-----Sort by LastName------");
            office.Employees.Sort(new LastNameCompare());
            foreach (Employee item in office.Employees)
            {
                Console.Write($"{item.GetEmployee()}\n");

            }
            Console.WriteLine("-----Sort by TaxId------");
            office.Employees.Sort(new TaxIdCompare());
            foreach (Employee item in office.Employees)
            {
                Console.Write($"{item.GetEmployee()}\n");

            }
            Console.WriteLine("-----Sort by Length Fn+Ln------");
            office.Employees.Sort(new FnameLnameLengthCompare());
            foreach (Employee item in office.Employees)
            {
                Console.Write($"{item.GetEmployee()}\n");

            }

        }        
    }
}
