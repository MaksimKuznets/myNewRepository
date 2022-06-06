using System;
using OpenQA.Selenium;


namespace homeTask70
{    
    public abstract class BasePage
    {
        protected IWebDriver Driver;

        protected BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        protected IWebElement FindElenemtByAnyMethod(By selector)
        {
            IWebElement element = null;
            try
            {
                Waiting.EmplicitWaitingForElement(Driver, 5, selector);
                 element = this.Driver.FindElement(selector);
                
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine("The system can't find element:", ex.Message);
            }
            return element;
        }
    }
}
