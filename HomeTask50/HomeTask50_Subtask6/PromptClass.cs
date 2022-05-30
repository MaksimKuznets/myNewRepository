using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace HomeTask50_Subtask6
{
   public class PromptClass:BasePage
    {
        private string callPromptButton = "//button[@class][text()='Click for Prompt Box']";
        public PromptClass(IWebDriver driver) : base(driver)
        {

        }
        public IAlert PromptCall()
        {
            FindElementByAnyMethod(By.XPath(callPromptButton)).Click();
            IAlert alert = new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.AlertIsPresent());
            alert = Driver.SwitchTo().Alert();
            return alert;
        }
    }     
}
