using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace HomeTask20
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://yandex.by/mail";
            LoginYandexPage Login = new LoginYandexPage(driver);
            Login.GoToLoginPage();
            Login.LoginToHomePage("TestSlenium", "5115556MaximKqwe235`");
            Thread.Sleep(5000);
            Elements locators = new Elements();
            IWebElement el = driver.FindElement(locators.elements["refreshButton"]);
            driver.Close();
        }
    }
}
