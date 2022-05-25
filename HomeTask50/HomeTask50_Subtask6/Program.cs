using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace HomeTask50_Subtask6
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            IWebDriver driver;
            driver = new ChromeDriver(options);
            driver.Url = "https://demo.seleniumeasy.com/javascript-alert-box-demo.html";
            //AlertClass al = new AlertClass(driver);
            //al.AlertCall();
            //al.GetAlert();
            //string okText = "//p[@id='confirm-demo']";
            //ConfirmClass confirm = new ConfirmClass(driver);
            //IAlert alerpPopU = confirm.CallToConfirm();
            //alerpPopU.Accept();
            //string text = confirm.FindElementByAnyMethod(By.XPath(okText)).Text;
            //  Assert.IsTrue(text.Equals("You pressed Cancel!"));
            PromptClass prompt = new PromptClass(driver);
            IAlert alert = prompt.PromptCall();
            alert.SendKeys("This is a test message");
            alert.Accept();
            Console.WriteLine();
        }
    }
}
