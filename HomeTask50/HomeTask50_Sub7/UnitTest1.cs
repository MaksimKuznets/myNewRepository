using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading.Tasks;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace HomeTask50_Sub7
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
            driver.Url = "https://demo.seleniumeasy.com/dynamic-data-loading-demo.html";
        }
        [Test]
        public void UserWaiting()
        {
            string selector = "//div[contains(text(),'First Name ') or contains(text(),'Last Name ')]";
            string button = "//button[@id]";
            driver.FindElement(By.XPath(button)).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(selector)));
        }
        [TearDown]
        public void Clear()
        {
            driver.Quit();
        }
    }
}