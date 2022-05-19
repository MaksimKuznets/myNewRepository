using System;
using OpenQA.Selenium;

namespace SelenuimFinalHometask
{
    public class HomeYandexPage : BasePage
    {
        private string topic = "Test Selenium Email";
        private string writeMailButton = "//span[text()='Написать']/parent::a";
        private string to = "//div[contains(@class,'MultipleAddressesDesktop-Field')]//div[@class='composeYabbles'][1]";
        private string theme = "//input[@name='subject']";
        private string findSender = "./descendant-or-self::span[contains(@title,'testslenium')]";
        private string sendButton = "//span[text()='Отправить']/ancestor::button";        
        public string textArea = "//div[@placeholder='Напишите что-нибудь'][@role]";
        private string unReadEmails = "//a[contains(@class,'is-unread')]";
        private string titleSendPopUp = "//span[text()='Письмо отправлено']/parent::div";
        public string emailMessage = "This email was sent " +
            "using seleniumTestProjectat " + DateTime.Now + " " +
            "Regards, Maksim Kuznets";
        public HomeYandexPage(IWebDriver driver) : base(driver)
        {

        }
        public void SendEmail(string email)
        {
            FindElementByXpath(writeMailButton).Click();            
            FindElementByXpath(to).SendKeys(email);           
            FindElementByXpath(theme).SendKeys(topic);            
            FindElementByXpath(textArea).SendKeys(emailMessage);            
            FindElementByXpath(sendButton).Click();            
        }
        public string TitleOfsendPopUp()
        {
            return FindElementByXpath(titleSendPopUp).Text;
        }
        public void FindUnreadEmails()
        {            
            var elements = FindElementsByXpath(unReadEmails);
            foreach (IWebElement item in elements)
            {
                try
                {
                    item.FindElement(By.XPath(findSender)).Click();                    
                    break;
                }
                catch
                {
                    continue;
                }
            }
        }
    }
        
}
