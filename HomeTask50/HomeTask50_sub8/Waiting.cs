using System;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace HomeTask50_sub8
{
    public abstract class Waiting
    {
        public static void EplicitWaiting(IWebDriver driver, int time, By by)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
                //throw new WebDriverTimeoutException();
            }
            catch (WebDriverTimeoutException)
            {
                throw new WebDriverTimeoutException();
            }
        }
    }
}