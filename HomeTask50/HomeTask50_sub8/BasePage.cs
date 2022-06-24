using System;
using OpenQA.Selenium;


namespace HomeTask50_sub8
{
    public abstract class BasePage
    {
        IWebDriver Driver = null;

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public IWebElement FindElementByAnyMethod(By by)
        {
            
            IWebElement element = null;
            try
            {
                Waiting.EplicitWaiting(Driver, 5, by);
                element = this.Driver.FindElement(by);
            }
            catch(WebDriverTimeoutException ex)
            {
                Console.WriteLine("The system can't find element:", ex.InnerException);
            }
            return element;
        }
    }
}
