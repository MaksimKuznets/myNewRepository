using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SelenuimFinalHometask;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace EmailUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver driver = null;
        public LoginYandexPage loginYandexPage = null;
        public MailLoginPage MailLog = null;
        [TestInitialize]
        public void TestInitialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);                             
        }
        [TestCleanup]
        public void TestCLeanUp()
        {
            driver.Close();
        }
        [TestMethod]
        public void LoginToYandex()
        {
            driver.Url = "https://yandex.by/mail";
            loginYandexPage = new LoginYandexPage(driver);
            loginYandexPage.GoToLoginPage();
            loginYandexPage.LoginToHomePage("TestSlenium", "5115556MaximKqwe235`");
            Assert.AreEqual(loginYandexPage.TestLogin(), "Написать");
        }
        [TestMethod]
        public void ReplyToYandexFromMail()
        {
            driver.Url = "https://mail.ru";
            MailLoginPage mailLoginPage = new MailLoginPage(driver);
            HomeMailPage homePage = new HomeMailPage(driver);
            mailLoginPage.GoToMailLoginPage();
            mailLoginPage.GoToHomePage("testslenium", "5115556v+");
            homePage.FindUnreadEmails();
            homePage.GoToResponsePopUpOnEmail();
            homePage.ReplyToEmail();
            Assert.IsTrue(homePage.isDisplay());
        }
        [TestMethod]
        public void SendEmailToMail()
        {
            driver.Url = "https://yandex.by/mail";
            loginYandexPage = new LoginYandexPage(driver);
            HomeYandexPage homePageYandex = new HomeYandexPage(driver);
            loginYandexPage.GoToLoginPage();
            loginYandexPage.LoginToHomePage("TestSlenium", "5115556MaximKqwe235`");
            homePageYandex.SendEmail("testslenium@mail.ru");
            Assert.AreEqual(homePageYandex.TitleOfsendPopUp(), "Письмо отправлено");
        }
        [TestMethod]
        public void ReadReplyFromMail()
        {
            driver.Url = "https://yandex.by/mail";
            loginYandexPage = new LoginYandexPage(driver);
            HomeYandexPage homePageYandex = new HomeYandexPage(driver);
            loginYandexPage.GoToLoginPage();
            loginYandexPage.LoginToHomePage("TestSlenium", "5115556MaximKqwe235`");
            string oldUrl = driver.Url;
            homePageYandex.FindUnreadEmails();            
            string url = driver.Url;
            if (!oldUrl.Equals(url))
            {
                Thread.Sleep(1000);
            }
            bool contain = url.Contains("#message");
            Assert.IsTrue(contain);
        }
        [TestMethod]
        public void WrongUsername()
        {
            driver.Url = "https://mail.ru";
            MailLoginPage mailLoginPage = new MailLoginPage(driver);
            Assert.AreEqual("Поле «Имя аккаунта» должно быть заполнено", mailLoginPage.EmptyUsername());
        }
    }
}
