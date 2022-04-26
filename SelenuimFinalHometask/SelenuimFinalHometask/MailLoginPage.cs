using OpenQA.Selenium;

namespace SelenuimFinalHometask
{
  public  class MailLoginPage:BasePage
    {
        private string loginbutton = "//div[contains(@class,'logged-out-one-click')]//button[text()='Войти']";
        private string userNameField = "//input[@name='username']";
        private string inputPasswordField = "//input[@name='password']";
        private string nextButton = "//span[text()='Ввести пароль']/parent::button";
        private string enterButton = "//span[text()='Войти']/parent::button";
        private string loginFrame = "//iframe[@class='ag-popup__frame__layout__iframe']";
        public string usernameErrorMessage = "//small[@data-test-id='required']/parent::div";
        public MailLoginPage(IWebDriver driver) : base(driver)
        {

        }
        public void GoToMailLoginPage()
        {
            FindElementByXpath(loginbutton).Click();            
        }
        public void GoToHomePage(string name,string password)
        {
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(loginFrame)));
            FindElementByXpath(userNameField).SendKeys(name);
            FindElementByXpath(nextButton).Click();
            FindElementByXpath(inputPasswordField).SendKeys(password);
            FindElementByXpath(enterButton).Click();
            Driver.SwitchTo().DefaultContent();
        }
        public string EmptyUsername()
        {
            FindElementByXpath(loginbutton).Click();
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(loginFrame)));
            FindElementByXpath(nextButton).Click();
            return FindElementByXpath(usernameErrorMessage).Text;
        }
  }
}