using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HomeTask50_sub9
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
            driver.Url = "https://demo.seleniumeasy.com/table-sort-search-demo.html";
            EmployeesTable emp = new EmployeesTable(driver,50.0);
          //  emp.GetPagination();
            var test = emp.AllEmployees();
            var test1 = emp.GetSpecificEmployees(20, 500000);
            Console.WriteLine("");
        }
    }
}
