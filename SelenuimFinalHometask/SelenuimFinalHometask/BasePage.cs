using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Linq;

namespace SelenuimFinalHometask
{
    public class BasePage
    {
        public IWebDriver Driver;
        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }
        public IWebElement FindElementByXpath(string xPath)
        {
            IWebElement element = null;            
                try
                {
                    Waiting.WaitTheElement(this.Driver, xPath);
                    element = Driver.FindElement(By.XPath(xPath));
                }
                catch
                {
                    Console.WriteLine("Can't find Element");                    
                }             
            return element;
        }       
        public List<IWebElement> FindElementsByXpath(string xPath)
        {
            List<IWebElement> elements=null;            
                try
                {
                    Waiting.WaitTheElement(this.Driver, xPath);
                    elements = Driver.FindElements(By.XPath(xPath)).ToList();
                }
                catch 
                {
                    Console.WriteLine("Can't find Element");
                }            
            return elements;
        }
    }
}
