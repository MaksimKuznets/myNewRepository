using System;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace HomeTask50_Subtask6
{
   public class PromptClass : BasePage
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
