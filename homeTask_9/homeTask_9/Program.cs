using System;
using System.Collections.Generic;
using homeTask_9.Comparators;
using System.Linq;

namespace homeTask_9
{
 
//Задача для всех- отсортируйте и выведите в консоль сотрудников по:
//1 Имени
//2. TaxID
//3. Общей длине имени и фамилии
//4* Умению ассанить таски- ITaskAssigner сначала(их допольнительно отсортировать по фамилии), потом все остальные

    //CДЕЛАТЬ ДАННОЕ ЗАДАНИЕ ЧЕРЕЗ LINQ
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
            var arraySortByName = office.Employees.OrderBy(x => x.Name);
            foreach (var item in arraySortByName)
            {
                Console.Write($"{item.GetEmployee()}\n");
             
            }
            Console.WriteLine("-----Sort AssigneTask by LastName------");
            var arraySortByLastName = office.Employees.OrderBy(x => x.LastName);
            foreach (var item in arraySortByLastName)
            {
                Console.Write($"{item.GetEmployee()}\n");

            }
            Console.WriteLine("-----Sort AssigneTask by TaxId------");
            var arraySortByTaxId = office.Employees.OrderBy(x => x.TaxId);
            foreach (var item in arraySortByTaxId)
            {
                Console.Write($"{item.GetEmployee()}\n");

            }

            Console.WriteLine("-----Sort AssigneTask by Asignee than Name------");
            var arraySortByAssigne = office.Employees.OrderByDescending(x => (x is IAssigner)).ThenBy(x => x.Name);
            foreach (var item in arraySortByAssigne)
            {
                Console.Write($"{item.GetEmployee()}\n");

            }
                       

        }
    }
}
