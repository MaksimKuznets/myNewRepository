using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HomeTask20;

namespace NUnitTest
{
    [TestFixture]
    public class Tests
    {
        public IWebDriver driver = null;
        public LoginYandexPage loginYandexPage = null;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
            driver.Url = "https://yandex.by/mail";
            loginYandexPage = new LoginYandexPage(driver);
            loginYandexPage.GoToLoginPage();
            loginYandexPage.LoginToHomePage("TestSlenium", "5115556MaximKqwe235`");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
        [Test]
        public void LoginTest()
        {            
            Assert.AreEqual(loginYandexPage.TestLogin(), "Написать");
        }
        [Test]
        public void AvatarIsDisplay()
        {
            Assert.IsTrue(loginYandexPage.TestAvatarImage().Displayed);
        }
    }
}