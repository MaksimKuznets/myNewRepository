using System;
using OpenQA.Selenium;

namespace HomeTask50
{
    public class YandexLoginPage
    {
        private string initialLoginButton = "//span[text()='Войти']/parent::a";
        private string usernameField = "//input[@name='login']";
        private string passwordField = "//input[@name='passwd']";
        private string loginButtonToHomePage = "//span[text()='Войти']/parent::button";
        private IWebDriver Driver { get; set; }   
        
        public YandexLoginPage(IWebDriver driver)
        {
            this.Driver = driver;
            // this is implementation of Implicit waiting. Configure the WebDriver instance to make
            // multiple attempts to find the element(s) on the page for a given period of time
            // if the element is not found. 
            //Implicit waits are usually set up immediately after a WebDriver instance is created and works
            //for the lifetime of that instance, although you can override them at any time.
            this.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }   
        
        public void GoToLoginPage()
        {           
                Driver.FindElement(By.XPath(initialLoginButton)).Click();        
        }

        public YandexHomePage LoginToHomePage(string username, string password)
        {
            Driver.FindElement(By.XPath(usernameField)).SendKeys(username);
            Driver.FindElement(By.XPath(loginButtonToHomePage)).Click();
            Driver.FindElement(By.XPath(passwordField)).SendKeys(password);
            Driver.FindElement(By.XPath(loginButtonToHomePage)).Click();
            return new YandexHomePage(Driver);
        }
    }
}
