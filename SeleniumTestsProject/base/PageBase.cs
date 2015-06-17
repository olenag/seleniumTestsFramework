using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestsProject
{
    public class PageBase
    {
        public IWebDriver _driver;

        protected PageBase(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Initialize()
        {
            PageFactory.InitElements(_driver, this);
        }

        public bool PrintTitles(IList<IWebElement> titles)
        {
            if (titles != null)
                foreach (var title in titles)
                {
                    Console.WriteLine(title.Text);
                }
            return true;
        }
    }
}
