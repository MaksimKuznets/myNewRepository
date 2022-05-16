using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace HomeTask20
{
    public class LoginYandexPage: BasePage
    {
        private string initialLoginButton = "//span[text()='Войти']/parent::a";
        private string usernameField = "//input[@name='login']";
        private string passwordField = "//input[@name='passwd']";
        private string loginButtonToHomePage = "//span[text()='Войти']/parent::button";
        private string writeMailButton = "//span[text()='Написать']/parent::a";
        private string avatarImage = "//img[@class='user-pic__image']";
        public LoginYandexPage(IWebDriver driver) : base(driver)
        {

        }
        public void GoToLoginPage()
        {
            FindElemtntByMethod(initialLoginButton).Click();
        }
        public void LoginToHomePage(string username, string password)
        {
            FindElemtntByMethod(usernameField).SendKeys(username);
            FindElemtntByMethod(loginButtonToHomePage).Click();
            FindElemtntByMethod(passwordField).SendKeys(password);
            FindElemtntByMethod(loginButtonToHomePage).Click();
        }
        public string TestLogin()
        {
            return FindElemtntByMethod(writeMailButton).Text;
        }
        public IWebElement TestAvatarImage()
        {
            return FindElemtntByMethod(avatarImage);
        }
    }
}
