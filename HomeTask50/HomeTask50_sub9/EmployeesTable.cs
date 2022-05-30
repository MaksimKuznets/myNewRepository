using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HomeTask50_sub9
{
    public class EmployeesTable
    {
        private string selectEntries = "//select";
        private string paginationAmount= "//a[contains(@class,'paginate_button')][not(@id)]";
        private string tableRow = "//table/tbody/child::tr";
        private string employeePropetry = "./descendant::td";
        IWebDriver Driver;
        double Time;
        public List<Employees> Employees;
        public EmployeesTable(IWebDriver driver, double time)
        {
            this.Driver = driver;
            this.Time = time;
            this.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(this.Time);
            this.Employees = new List<Employees>();
        }
        public void SetUpDefaultEntries()
        { 
            IWebElement select = Driver.FindElement(By.XPath(selectEntries));
            var selectObject = new SelectElement(select);
            selectObject.SelectByText("10");
        }
        public IList<IWebElement> GetPagination()
        {
            var pgnCollect = Driver.FindElements(By.XPath(paginationAmount));
            return pgnCollect;
        }
        public IList<IWebElement> GetPageEmployee()
        {
            var employees = Driver.FindElements(By.XPath(tableRow));
            return employees;
        }
        public List<Employees> AllEmployees()
        {
            var paginationCount = this.GetPagination().Count;
            List<Employees> employeesCollection = new List<Employees>();
            for (int i=0;i< paginationCount; i++)
            {
                IWebElement pgn= Driver.FindElement(By.XPath("//a[contains(@class,'paginate_button')][not(@id)][position()=" + (i+1) + "]"));
                pgn.Click();
                var allPageEmployees = this.GetPageEmployee();
                foreach(IWebElement row in allPageEmployees)
                {
                    employeesCollection.Add(this.GetEmployee(row));
                }                
            }
            return employeesCollection;
        }
        public Employees GetEmployee(IWebElement emp)
        {
            Employees employee = new Employees();
            var employeeProperties = emp.FindElements(By.XPath(employeePropetry)).ToArray();
            for(int i=0;i< employeeProperties.Length;i++)
            {
                employee[i] = employeeProperties[i].Text;
            }
            return employee;
        }
        public List<Employees> GetSpecificEmployees(int _age, int _salary)
        {
            var employees = this.AllEmployees();
            var temp = employees.Where(x => x.Salary <= _salary && x.Age > _age).ToList();
            return temp;
        }
    }
}
