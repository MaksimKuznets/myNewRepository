using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace HomeTask20
{
  public  class Elements
    {
        public Dictionary<String,By> elements;
            public Elements()
        {
            elements = new Dictionary<String, By>()
            {
                // home page
                {"writeEmailButtonXPath", By.XPath("//span[text()='Написать']/parent::a") },
                {"inboxLink", By.ClassName("Folder-m__link--2z6Y5") },
                {"searchInput", By.TagName("input[placeholder='Поиск']") },
                {"refreshButton", By.CssSelector("button.Button2.Button2_view_clear.mail-GhostButton") },
                {"testNameTag", By.Name("msapplication-TileColor") },
                // login page
                {"loginButton", By.Id("passp:sign-in") },
                {"LearnMore", By.LinkText("Узнать больше") },
                {"forgotMail", By.PartialLinkText("помню") }                
            };
        }
    }
}
