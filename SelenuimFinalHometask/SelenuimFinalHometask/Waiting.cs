using System;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace SelenuimFinalHometask
{
    public class Waiting
    {
        public static void WaitTheElement(IWebDriver driver, string xPath, int time = 7) 
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(ExpectedConditions.ElementExists(By.XPath(xPath)));
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(ExpectedConditions.ElementIsVisible(By.XPath(xPath)));
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(ExpectedConditions.ElementToBeClickable(By.XPath(xPath)));            
        }
    }
}
