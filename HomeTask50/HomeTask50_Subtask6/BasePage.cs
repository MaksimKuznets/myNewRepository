using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

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
                    new NoSuchElementException();
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
