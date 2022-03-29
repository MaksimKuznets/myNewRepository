using System;
using System.Collections.Generic;
using homeTask_8.Comparators;

namespace homeTask_8
{
   
//Задача для всех- отсортируйте и выведите в консоль сотрудников по:
//1. Имени
//2. TaxID
//3. Общей длине имени и фамилии
//4* Умению ассанить таски- ITaskAssigner сначала(их допольнительно отсортировать по фамилии), потом все остальные


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
