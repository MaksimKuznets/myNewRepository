using OpenQA.Selenium;
using System;
using System.IO;


namespace homeTask70
{
    public class YandexHomePage : BasePage
    {
        private string profileButton = "//span[@class='avatar__image-wrapper']/parent::a";
        private string logOut = "//span[text()='Выйти']/parent::a";

        public YandexHomePage(IWebDriver driver) : base(driver)
        {

        }

        public YandexHomePage SubmitProfileButton()
        {
            FindElementByAnyMethod(By.XPath(profileButton)).Click();
            return this;
        }

        public YandexHomePage SubmitLogOutButton()
        {
            FindElementByAnyMethod(By.XPath(logOut)).Click();
            return this;
        }

        public YandexLoginPage LogOut()
        {
            SubmitProfileButton();
            SubmitLogOutButton();
            return new YandexLoginPage(Driver);
        }

        public bool IsDisplayAvatar()
        {
            return FindElementByAnyMethod(By.XPath(profileButton)).Displayed;
        }        
    }
}
