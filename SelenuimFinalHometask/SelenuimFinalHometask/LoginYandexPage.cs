using OpenQA.Selenium;

namespace SelenuimFinalHometask
{
    public class LoginYandexPage:BasePage
    {
        private string writeMailButton = "//span[text()='Написать']/parent::a";
        private string _loginButton = "//span[text()='Войти']/parent::a";
        private string loginField = "//input[@name='login']";
        private string passwordField = "//input[@name='passwd']";
        private string _loginButtonToHomePage = "//span[text()='Войти']/parent::button";      
        public LoginYandexPage(IWebDriver driver) : base(driver)
        {

        }
        public void GoToLoginPage()
        {
            FindElementByXpath(_loginButton).Click();            
        }
        public void LoginToHomePage(string username, string password)
        {
           FindElementByXpath(loginField).SendKeys(username);            
           FindElementByXpath(_loginButtonToHomePage).Click();            
           FindElementByXpath(passwordField).SendKeys(password);            
           FindElementByXpath(_loginButtonToHomePage).Click();           
        }        
        public string TestLogin()
        {
            return FindElementByXpath(writeMailButton).Text;
        }
    }
}
