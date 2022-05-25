using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using HomeTask50_Subtask6;


namespace NUnit_Sub6
{
    public class Tests
    {
        IWebDriver driver = null;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
            driver.Url = "https://demo.seleniumeasy.com/javascript-alert-box-demo.html";
        }
        [Test, Order(3)]
        public void TestAlert()
        {
            AlertClass alert = new AlertClass(driver);
            alert.AlertCall();
            Assert.IsTrue(alert.GetAlert().Text.Equals("I am an alert box!"));
        }
        [Test,Order(1)]
        public void TestConfirmOkButton()
        {
            string confirmText = "//p[@id='confirm-demo']";
            ConfirmClass confirm = new ConfirmClass(driver);
            IAlert alerpPopU = confirm.ConfirmCall();
            alerpPopU.Accept();
            string text = confirm.FindElementByAnyMethod(By.XPath(confirmText)).Text;
            Assert.IsTrue(text.Equals("You pressed OK!"));
        }
        [Test, Order(2)]
        public void TestConfirmCancelButton()
        {
            string confirmTextSelector = "//p[@id='confirm-demo']";
            ConfirmClass confirm = new ConfirmClass(driver);
            IAlert alerpPopU = confirm.ConfirmCall();
            alerpPopU.Dismiss();
            string text = confirm.FindElementByAnyMethod(By.XPath(confirmTextSelector)).Text;
            Assert.IsTrue(text.Equals("You pressed Cancel!"));
        }
        [Test, Order(4)]
        public void TestPrompt()
        {
            string promptTextSelector = "//p[@id='prompt-demo']";
            string expectedmessage = "This is a test message!";
            PromptClass prompt = new PromptClass(driver);
            IAlert alert = prompt.PromptCall();
            alert.SendKeys("This is a test message!");
            alert.Accept();
            string promptText = prompt.FindElementByAnyMethod(By.XPath(promptTextSelector)).Text;
            Assert.IsTrue(promptText.Contains(expectedmessage));
        }        
        [TearDown]
        public void Clear()
        {
            driver.Quit();
        }
    }
}