using System;
using System.Collections.Generic;
using homeTask_7.Comparators;
using System.Linq;

namespace homeTask_7
{
    //7#
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

    //8#
    //Задача для всех- отсортируйте и выведите в консоль сотрудников по:
    //1. Имени
    //2. TaxID
    //3. Общей длине имени и фамилии
    //4* Умению ассанить таски- ITaskAssigner сначала(их допольнительно отсортировать по фамилии), потом все остальные

    //9#
    //CДЕЛАТЬ ДАННОЕ ЗАДАНИЕ ЧЕРЕЗ LINQ

    class Program
    {
        static void Main(string[] args)
        {
            BAEmployee BA = new BAEmployee("Ivan", "Kovalev", 4);
            DevEmployee Dev = new DevEmployee("Slava", "Rossiytsev", 55);
            DevTeamLead DevTL = new DevTeamLead("Maksim", "Medunitsa", 65);
            PMEmployee PM = new PMEmployee("Anastasia", "Bogdanova", 1);
            QAAutomationEmployee QAAutomation = new QAAutomationEmployee("Yana", "Grechikho", 554);
            QAAutomationTeamLead QAutomationTL = new QAAutomationTeamLead("Alexander", "Savenok", 77);
            QAEmployee QA = new QAEmployee("Maksim", "Kuznets", 69);
            QATeamLead QATL = new QATeamLead("Tatiana", "Dubitskaya", 123);
            Employee[] emp = { BA, Dev, DevTL, PM, QAAutomation, QAutomationTL, QA, QATL };
            Office office = new Office();
            office.AddEmployees(emp);
            Console.WriteLine("********************************************** 7task");
            foreach (Employee item in office.Employees)
            {
                if (item is IAssigner)
                {
                    Console.Write($"{item.GetEmployee()}");  
                    ((IAssigner)item).AssigneTask();
                }

                if (item is ICoding)
                {
                    Console.Write($"{item.GetEmployee()}");
                    ((ICoding)item).WriteCode();
                }

                if (item is IReview)
                {
                    Console.Write($"{item.GetEmployee()}");
                    ((IReview)item).CodeReview();
                }                
            }
            Console.WriteLine("********************************************** 8task");
            //8 task
            Console.WriteLine("-----Sort AssigneTask by Name------");
            office.Employees.Sort(new AssigneTaskCompare());
            foreach (Employee item_1 in office.Employees)
            {
                if (item_1 is IAssigner)
                {
                    Console.WriteLine($"{item_1.GetEmployee()} assigner");                    
                }
               else Console.WriteLine($"{item_1.GetEmployee()}");
            }
            Console.WriteLine("-----Sort by Name------");
            office.Employees.Sort(new FirstNameCompare());
            office.PrintOffice();           
            Console.WriteLine("-----Sort by LastName------");
            office.Employees.Sort(new LastNameCompare());
            office.PrintOffice();
            Console.WriteLine("-----Sort by TaxId------");
            office.Employees.Sort(new TaxIdCompare());
            office.PrintOffice();
            Console.WriteLine("-----Sort by Length Fn+Ln------");
            office.Employees.Sort(new FnameLnameLengthCompare());
            office.PrintOffice();
            Console.WriteLine("********************************************** 9task");
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
