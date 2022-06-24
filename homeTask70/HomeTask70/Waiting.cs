using System;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;


namespace homeTask70
{
    public abstract class Waiting
    {
        public static void EmplicitWaitingForElement(IWebDriver driver, int time, By by)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (WebDriverTimeoutException)
            {
                throw new WebDriverTimeoutException();
            }
        }
    }
}
