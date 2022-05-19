using OpenQA.Selenium;

namespace HomeTask20
{
    public class LoginYandexPage: BasePage
    {
        private string initialLoginButton = "//span[text()='Войти']/parent::a";
        private string usernameField = "//input[@name='login']";
        private string passwordField = "//input[@name='passwd']";
        private string loginButtonToHomePage = "//span[text()='Войти']/parent::button";
        private string writeMailButton = "//span[text()='Написать']/parent::a";
        private string avatarImage = "//img[@class='user-pic__image']";
        public LoginYandexPage(IWebDriver driver) : base(driver)
        {

        }
        public void GoToLoginPage()
        {
            FindElemtntByMethod(By.XPath(initialLoginButton)).Click();
        }
        public void LoginToHomePage(string username, string password)
        {
            FindElemtntByMethod(By.XPath(usernameField)).SendKeys(username);
            FindElemtntByMethod(By.XPath(loginButtonToHomePage)).Click();
            FindElemtntByMethod(By.XPath(passwordField)).SendKeys(password);
            FindElemtntByMethod(By.XPath(loginButtonToHomePage)).Click();
        }
        public string TestLogin()
        {
            return FindElemtntByMethod(By.XPath(writeMailButton)).Text;
        }
        public IWebElement TestAvatarImage()
        {
            return FindElemtntByMethod(By.XPath(avatarImage));
        }
    }
}
