using System;
using OpenQA.Selenium;

namespace HomeTask50
{
     public class YandexHomePage
    {
        private string writeMailButton = "//span[text()='Написать']/parent::a";
        private string avatarImage = "//img[@class='user-pic__image']";
        private IWebDriver Driver { get; set; }   
        
        public YandexHomePage(IWebDriver driver)
        {
            this.Driver = driver;
            // this is implementation of Implicit waiting. Configure the WebDriver instance to make
            // multiple attempts to find the element(s) on the page for a given period of time
            // if the element is not found. 
            //Implicit waits are usually set up immediately after a WebDriver instance is created and works
            //for the lifetime of that instance, although you can override them at any time.
            this.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        public string TestLogin()
        {
            return Driver.FindElement(By.XPath(writeMailButton)).Text;
        }

        public IWebElement TestAvatarImage()
        {
            return Driver.FindElement(By.XPath(avatarImage));
        }
    }
}
