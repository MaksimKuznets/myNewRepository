using System;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace HomeTask20
{
    class Waiting
    {
        public static void WaitTheElement(IWebDriver driver, string xPath, int time = 5)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(ExpectedConditions.ElementExists(By.XPath(xPath)));
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(ExpectedConditions.ElementIsVisible(By.XPath(xPath)));
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(ExpectedConditions.ElementToBeClickable(By.XPath(xPath)));
        }
    }
}
