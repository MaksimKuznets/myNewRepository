
using OpenQA.Selenium;

namespace HomeTask50_Subtask6
{
    public class AlertClass : BasePage
    {
        private string alertPopUp = "//button[text()='Click me!'][not(contains(@class,'btn-lg'))]";

        public AlertClass(IWebDriver driver) : base(driver)
        {

        }

        public void AlertCall()
        {
            FindElementByAnyMethod(By.XPath(alertPopUp)).Click();
        }

        public IAlert GetAlert()
        {
            IAlert alert = Driver.SwitchTo().Alert();
            return alert;
        }
    }
}
