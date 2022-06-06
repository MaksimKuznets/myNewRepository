using System;
using OpenQA.Selenium;
using System.IO;


namespace homeTask70
{
    public abstract class ScreenShot
    {
        public static void TakeScreenshot(IWebDriver Driver)
        {
            try
            {
                Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
                string currentTime = DateTime.Now.ToString("dd_MM_yy_HH_mm_ss");
                string path = Directory.GetCurrentDirectory().Replace(Directory.GetCurrentDirectory(), @"C:\Users\max\Git\newGitFolder\homeTask70\images\");
                ss.SaveAsFile(path + currentTime + ".png", ScreenshotImageFormat.Png);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something wrong", e.Message);
            }
        }
    }
}
