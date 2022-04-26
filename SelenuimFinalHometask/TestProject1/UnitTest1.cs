using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SelenuimFinalHometask;
using OpenQA.Selenium.Chrome;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver driver = null;
        public LoginPageYandex loginYandexPage = null;
        [TestInitialize]
        public void TestInitialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver();
            driver.Url = "https://yandex.by/mail";
            loginYandexPage = new LoginPageYandex(driver);
        }
        [TestCleanup]
        public void TestCLeanUp()
        {
             driver.Close();
        }
        [TestMethod]
        public void LoginToYandex()
        {
            loginYandexPage.GoToLoginPage();
            loginYandexPage.LoginToHomePage("TestSlenium", "5115556MaximKqwe235`");
            Assert.AreEqual(loginYandexPage.TestLogin(), "Написать");
        }
    }
}
