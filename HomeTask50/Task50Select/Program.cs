using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Task50Select
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://demo.seleniumeasy.com/basic-select-dropdown-demo.html";
            MultiSelectPage max = new MultiSelectPage(driver);
            IList<IWebElement> el = max.GetRandomOptions(max.GetOptions(), max.GetOptions().Count);
        }
    }
}
