using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeTask20
{
    public class BasePage
    {
        protected IWebDriver Driver;
        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }
        public IWebElement FindElemtntByMethod(By selector)
        {
            IWebElement element = null;
            try
            {
                Waiting.WaitTheElement(this.Driver, selector);
                element = Driver.FindElement(selector);
            }
            catch
            {
                Console.WriteLine("Can't find Element");
            }
            return element;
        }
    }
}
