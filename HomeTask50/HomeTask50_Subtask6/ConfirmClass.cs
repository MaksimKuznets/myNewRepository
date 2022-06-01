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
    public class ConfirmClass : BasePage
    {
        private string alertPopUpButton = "//button[contains(@class,'btn-lg')][text()='Click me!']";

        public ConfirmClass(IWebDriver driver) : base(driver)
        {

        }

        public IAlert ConfirmCall()
        {
            FindElementByAnyMethod(By.XPath(alertPopUpButton)).Click();
            IAlert alert = new WebDriverWait(Driver,TimeSpan.FromSeconds(5)).Until(ExpectedConditions.AlertIsPresent());
            alert = Driver.SwitchTo().Alert();
            return alert;
        } 
    }
}
