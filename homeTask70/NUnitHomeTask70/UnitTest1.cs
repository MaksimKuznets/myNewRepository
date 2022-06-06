using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using homeTask70;
using System;


namespace NUnitHomeTask70
{
    [TestFixture]
    public class Tests
    {
        IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            Driver = new ChromeDriver(options);
            Driver.Url = "https://yandex.by";
        }

        [Test]
        [TestCase("TestSlenium", "5115556MaximKqwe235`")]
        public void LogInMethod(String _username, String _password)
        {
            YandexLoginPage lPage = new YandexLoginPage(Driver);
            YandexHomePage hPage = lPage.GoToHomePage(_username, _password);
            Assert.IsTrue(hPage.IsDisplayAvatar(), "The expected value is displayng profile's avatar after Login");
        }

        [Test]
        [TestCase("TestSlenium", "5115556MaximKqwe235`")]
        public void LogOutMethod(String _username, String _password)
        {
            YandexLoginPage lPage = new YandexLoginPage(Driver);
            YandexHomePage hPage = lPage.GoToHomePage(_username, _password);
            lPage = hPage.LogOut();
            Assert.IsTrue(lPage.IsDisplayEnterButton(), "The expected value is displaing enter's button after LogOut");
        }

        [TearDown]
        public void Clear()
        {
            Driver.Quit();
        }
    }
}