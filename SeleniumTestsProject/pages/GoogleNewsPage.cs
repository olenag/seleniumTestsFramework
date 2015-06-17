using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestsProject
{
    public class GoogleNewsPage : PageBase
    {
        public GoogleNewsPage(IWebDriver driver) : base(driver) {}

        public IList<IWebElement> FindNewsTitles()
        {
           return _titles;
        }

        public string TopStoryTitle
        {
            get { return _titles.First().Text; }
        }
        
        [FindsBy(How = How.XPath, Using = "//h2[@class='esc-lead-article-title']//span[@class='titletext']")]
        private IList<IWebElement> _titles;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'probe-top-story')]//h2/a/span/text()")] 
        private IWebElement _topStoryTitle;

    }
}