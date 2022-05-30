using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeTask50_sub8
{
   public class DownloadFile:BasePage
    {
        private string downloadButton = "//button[@id='cricle-btn']";        
        public DownloadFile(IWebDriver driver):base(driver)
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
