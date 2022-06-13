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
                string path = null;
                Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
                string currentTime = DateTime.Now.ToString("dd_MM_yy_HH_mm_ss");
                string workingDirectory = Environment.CurrentDirectory;
                string parentProjectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName;
                if (Directory.Exists(parentProjectDirectory + "\\images"))
                {
                    path = parentProjectDirectory + "\\images";
                    ss.SaveAsFile(path + "\\" + currentTime + ".png", ScreenshotImageFormat.Png);
                }
                else
                {
                    Directory.CreateDirectory(parentProjectDirectory + "\\images");
                    ss.SaveAsFile(path + "\\" + currentTime + ".png", ScreenshotImageFormat.Png);
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine("Something wrong", e.Message);
            }
        }
    }
}
