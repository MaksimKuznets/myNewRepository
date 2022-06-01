using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HomeTask50_sub9;

namespace NUnit_sub9
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver = null;

        [SetUp]
        public void Setup()
        {            
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
            driver.Url = "https://demo.seleniumeasy.com/table-sort-search-demo.html";
        }

        [Test]
        public void TestSpecificEmployeesMethod()
        {
            EmployeesTable emp = new EmployeesTable(driver);
            var employees = emp.GetSpecificEmployees(35, 900000);
            Assert.NotNull(employees);
        }

        [TearDown]
        public void Clear()
        {
            driver.Quit();
        }
    }
}