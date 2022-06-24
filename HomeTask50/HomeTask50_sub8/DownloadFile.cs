using OpenQA.Selenium;

namespace HomeTask50_sub8
{
   public class DownloadFile : BasePage
    {
        private string downloadButton = "//button[@id='cricle-btn']";  
        
        public DownloadFile(IWebDriver driver) : base(driver)
        {
            
        }

        public void ClickByDownloadButton()
        {
            FindElementByAnyMethod(By.XPath(downloadButton)).Click();
        }
       
        public string DeleleteExtraCharacters(string str)
        {
            char percentage = '%';
            return str.TrimEnd(percentage);
        }
    }
}
