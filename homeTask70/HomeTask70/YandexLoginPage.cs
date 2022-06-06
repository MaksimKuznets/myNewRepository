﻿using System;
using OpenQA.Selenium;


namespace homeTask70
{
    public class YandexLoginPage : BasePage
    {
        private string usernameField = "//input[@name='login']";
        private string paswordField = "//input[@name='passwd']";
        private string submitButton = "//button[@id='passp:sign-in']";
        private string enterButton = "//div[text()='Войти']/parent::a";
        
        public YandexLoginPage(IWebDriver driver) : base(driver)
        {
            
        }

        public YandexLoginPage SetUsername(String _username)
        {
            FindElenemtByAnyMethod(By.XPath(usernameField)).SendKeys(_username);
            return this;
        }

        public YandexLoginPage SetPassword(String _password)
        {
            FindElenemtByAnyMethod(By.XPath(paswordField)).SendKeys(_password);
            return this;
        }

        public YandexLoginPage SubmitToLoginButton()
        {
            FindElenemtByAnyMethod(By.XPath(submitButton)).Click();
            return this;
        }

        public YandexLoginPage SubmitToEnterButton()
        {
            FindElenemtByAnyMethod(By.XPath(enterButton)).Click();
            return this;
        }

        public YandexHomePage GoToHomePage(String _username, String _password)
        {
            SubmitToEnterButton();
            SetUsername(_username);
            SubmitToLoginButton();
            SetPassword(_password);
            SubmitToLoginButton();
            return new YandexHomePage(Driver);
        }

        public bool IsDisplayEnterButton()
        {
            return FindElenemtByAnyMethod(By.XPath(enterButton)).Displayed;
        }
    }
}
