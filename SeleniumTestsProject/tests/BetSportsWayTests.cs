using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTestsProject
{
    
    public class BetSportsWayTests : TestBase
    {
        private BetSportsWayPage _betSportsWayPage;
        
        [Test]
        public void Can_print_out_live_games_titles()
        {
            _betSportsWayPage = OpenBetSportsWayPage(Driver);
            var titles = _betSportsWayPage.FindLiveGamesTitles();

            Assert.IsNotNull(titles);
            
            var liveGameTitlesprinted = _betSportsWayPage.PrintTitles(titles);
            Assert.IsTrue(liveGameTitlesprinted);
        }

        private BetSportsWayPage OpenBetSportsWayPage(IWebDriver driver)
        {
            driver.Url = "https://sports.betway.com/";
            var betSportsWayPage = new BetSportsWayPage(driver);
            betSportsWayPage.Initialize();
            return betSportsWayPage;
        }
    }
}

