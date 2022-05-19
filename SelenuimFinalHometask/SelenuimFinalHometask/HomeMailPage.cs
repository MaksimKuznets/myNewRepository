using OpenQA.Selenium;

namespace SelenuimFinalHometask
{
  public class HomeMailPage:BasePage
    {
        private string replyOnEmail = "Reply to Received Email Via Selenium";
        private string reTopic = "Reply from Mail.ru using Selenium";
        private string unReadEmails = "//div[contains(@class,'llc__avatar_unread')]/parent::a";
        private string findSender = "./descendant-or-self::span[contains(@title,'testslenium')]";
        private string answeButton = "//span[@title='Ответить']/parent::div";
        private string reInput = "//input[contains(@value,'Re')]";
        private string emailTextArea = "//div[@role='textbox']/child::div";
        private string sendButton = "//span[@title = 'Отправить']";
        private string replyToEmailWindow = "//div[@class='layer-window__block']";
        public HomeMailPage(IWebDriver driver) : base(driver)
        {

        }
        public void FindUnreadEmails()
        {   
            var elements = FindElementsByXpath(unReadEmails);
            foreach (IWebElement item in elements)
            {
                try
                {
                    item.FindElement(By.XPath(findSender)).Click();                    
                }
                catch
                {
                    continue;
                }               
            }         
        }
        public void GoToResponsePopUpOnEmail()
        {
            FindElementByXpath(answeButton).Click();
        }
        public void ReplyToEmail()
        {            
            FindElementByXpath(reInput).Clear();                       
            FindElementByXpath(emailTextArea).SendKeys(replyOnEmail);
            FindElementByXpath(sendButton).Click();            
        }
        public bool isDisplay()
        {
            return FindElementByXpath(replyToEmailWindow).Displayed;
        }
    }
}
