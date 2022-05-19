using System;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace HomeTask20
{
    class Waiting
    {
        public static void WaitTheElement(IWebDriver driver,By selector, int time = 5)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(ExpectedConditions.ElementExists(selector));
            wait.Until(ExpectedConditions.ElementIsVisible(selector));
            wait.Until(ExpectedConditions.ElementToBeClickable(selector));
        }
    }
}
