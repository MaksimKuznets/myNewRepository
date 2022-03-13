using System;

namespace homeTask_7
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
            BAEmployee BA = new BAEmployee("Ivan", "Kovalev");
            DevEmployee Dev = new DevEmployee("Slava", "Rossiytsev");
            DevTeamLead DevTL = new DevTeamLead("Maksim", "Medunitsa");
            PMEmployee PM = new PMEmployee("Anastasia", "Bogdanova");
            QAAutomationEmployee QAAutomation = new QAAutomationEmployee("Yana","Grechikho");
            QAAutomationTeamLead QAutomationTL = new QAAutomationTeamLead("Alexander", "Savenok");
            QAEmployee QA = new QAEmployee("Maksim", "Kuznets");
            QATeamLead QATL = new QATeamLead("Tatiana","Dubitskaya");
            Employee[] emp = { BA, Dev, DevTL, PM, QAAutomation, QAutomationTL, QA, QATL };

            Office office = new Office();

            //foreach(Employee item in emp)
            //{
            //    office.employee.Add(item);
            //}
            office.employee.AddRange(emp);

            foreach (Employee item in office.employee)
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
        }
    }
}
