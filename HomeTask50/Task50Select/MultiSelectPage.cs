using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task50Select
{
   public class MultiSelectPage
    {
        private string selector = "//select[@name='States']";
        protected IWebDriver Driver { get; set; }
        public MultiSelectPage(IWebDriver driver)
        {
            this.Driver = driver;
        }       
        public SelectElement GetSelectItem()
        {
            IWebElement select = Driver.FindElement(By.XPath(selector));
            var selectObject = new SelectElement(select);
            return selectObject;
        }
        public IList<IWebElement> GetOptions()
        {
            IWebElement select = Driver.FindElement(By.XPath(selector));
            var selectObject = new SelectElement(select);
            IList<IWebElement> allOptions = selectObject.Options;
            return allOptions;           
        }
        public IList<IWebElement> GetRandomOptions(IList<IWebElement> list, int value)
        {
            IList<IWebElement> options = new List<IWebElement>();
            for (int i = 0; i < 3; i++)
            {
                Random rand = new Random();
                int num = rand.Next(value);
                if (options.Contains(list[num]))
                {
                    i--;
                }
                else
                {
                    options.Add(list[num]);
                }
            }
            return options;
        }        
    }
}
