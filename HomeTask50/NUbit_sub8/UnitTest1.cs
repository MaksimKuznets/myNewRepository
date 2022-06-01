using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using HomeTask50_sub8;
using System;

namespace NUbit_sub8
{
    [TestFixture]
    public class Tests
    {
        string percent = "//div[@class='percenttext']";
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");            
            driver = new ChromeDriver(options);
            driver.Url = "https://demo.seleniumeasy.com/bootstrap-download-progress-demo.html";
        }

        [Test]
        public void TestPercantage()
        {            
            DownloadFile obj = new DownloadFile(driver);
            obj.ClickByDownloadButton();
            int value = 0;
            do
            {
                string percentage = obj.FindElementByAnyMethod(By.XPath(percent)).Text;
                percentage = obj.DeleleteExtraCharacters(percentage);
                value = Int32.Parse(percentage);
            }
            while (value <= 50);
            driver.Navigate().Refresh();
            // Get the default percentage before attempting to download the file
            string percentageAfterRefresh = obj.FindElementByAnyMethod(By.XPath(percent)).Text;
            Assert.AreEqual("0%", percentageAfterRefresh,"The  expected value should be the same with actual after refreshing the pasge");
        }

        [TearDown]
        public void Clear()
        {
            driver.Quit();
        }
    }
}