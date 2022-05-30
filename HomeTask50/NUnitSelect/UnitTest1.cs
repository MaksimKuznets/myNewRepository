using NUnit.Framework;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Task50Select;
using System.Collections.Generic;
using System;

namespace NUnitSelect
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver = null;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = "https://demo.seleniumeasy.com/basic-select-dropdown-demo.html";
        }
        [Test]
        public void ValidationSelectedElements()
        {
            MultiSelectPage select = new MultiSelectPage(driver);
            IList<IWebElement> list = select.GetRandomOptions(select.GetOptions(), select.GetOptions().Count);
            List<string> names = list.Select(x => x.Text).ToList();
            SelectElement selectItem = select.GetSelectItem();
            selectItem.SelectByText(names[0]);
            selectItem.SelectByText(names[1]);
            selectItem.SelectByText(names[2]);
            IList<IWebElement> selectedList = selectItem.AllSelectedOptions;
            CollectionAssert.AreEquivalent(list, selectedList);
        }
        [TearDown]
        public void Clear()
        {
            driver.Quit();
        }
    }
}