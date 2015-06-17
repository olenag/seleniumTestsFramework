using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestsProject
{
    class BetSportsWayPage : PageBase
    {
        public BetSportsWayPage(IWebDriver driver) : base(driver) { }

        public IList<IWebElement> FindLiveGamesTitles()
        {
            return _titles;
        }
        
        [FindsBy(How = How.XPath, Using = "//div[contains(@id, 'inplay-module')]//div[@class='marketTitle']/a")]
        private IList<IWebElement> _titles;
    }
}
