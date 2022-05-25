﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

using OpenQA.Selenium.Support.UI;

namespace HomeTask50_Subtask6
{
    public abstract class Waiting
    {
        public static void EplicitWaiting(IWebDriver driver,int time, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
            
        }
    }
}
