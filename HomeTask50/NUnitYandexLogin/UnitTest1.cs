using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading.Tasks;
using HomeTask50;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace NUnitYandexLogin
{
        public class Tests
    {
        public IWebDriver driver;
        string avatarImage = "//div[contains(@class,'user-pic')]/child::img[@class='user-pic__image']";

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
            driver.Url = "https://yandex.by/mail";
            
        }
        [Test]
        //[TestCase("TestSlenium", "5115556MaximKqwe235`")]
        [TestCase("TestSlenium", "5115556MaximKqwe235`")]
        public void TestLoginFirstMethodImplicitWait(String username, String password)
        {
            YandexLoginPage loginPage = new YandexLoginPage(driver, 10.0);
            loginPage.GoToLoginPage();
            YandexHomePage homePage = loginPage.LoginToHomePage(username, password);
            Assert.AreEqual(homePage.TestLogin(), "Написать");
        }
        [Test]
        //[TestCase("TestSlenium", "5115556MaximKqwe235`")]
        [TestCase("TestSlenium", "5115556MaximKqwe235`")]
        public void TestLoginFirstMethodExplicitWait(String username, String password)
        {
            YandexLoginPage loginPage = new YandexLoginPage(driver,5.0);
            loginPage.GoToLoginPage();
            // This is another example of Implicit wait. Sleep pauses for the specified number of milliseconds.
            Thread.Sleep(5);
            YandexHomePage homePage = loginPage.LoginToHomePage(username, password);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //In this case the system will be wait for the element  for 10 seconds,
            //but will continue execution as soon as the element is found.
            IWebElement element = wait.Until(driver => driver.FindElement(By.XPath(avatarImage)));
            Assert.IsTrue(element.Displayed);
        }
        [TearDown]
        public void Clear()
        {
            driver.Quit();
        }
    }
}