using System;
using OpenQA.Selenium;

namespace HomeTask50_Subtask6
{
    public abstract class BasePage
    {
        protected IWebDriver Driver = null;

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public IWebElement FindElementByAnyMethod(By by)
        {
            IWebElement element = null;
            try
            {
                Waiting.EplicitWaiting(this.Driver, 5, by);
                element = this.Driver.FindElement(by);
                if (element == null)
                {
                   throw new NoSuchElementException();
                }               
            }
            catch(NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
            }
            return element;
        }
    }
}
