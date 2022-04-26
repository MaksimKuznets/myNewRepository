using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SelenuimFinalHometask
{
    class Program
    {
        static void Main(string[] args)
        {
            ////string path = "is-unread";
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://yandex.by/mail";
            LoginYandexPage Login = new LoginYandexPage(driver);
            HomeYandexPage Home = new HomeYandexPage(driver);
            Login.GoToLoginPage();
            Login.LoginToHomePage("TestSlenium", "5115556MaximKqwe235`");
            // Home.SendEmail("kasimby@mail.ru");
            Home.FindUnreadEmails();

            //IWebDriver driver1 = new ChromeDriver(options);
            //driver1.Url = "https:\\mail.ru";
            //MailLoginPage MailLog = new MailLoginPage(driver1);
            //MailLog.GoToMailLoginPage();
            //MailLog.GoToHomePage("testslenium", "5115556v+");
            //HomeMailPage mailhomepage = new HomeMailPage(driver1);
            //mailhomepage.FindUnreadEmails();
            //mailhomepage.GoToResponsePopUpOnEmail();
            //mailhomepage.ReplyToEmail();
            //mailhomepage.test();
            //driver1.Close();
        }
    }
}
