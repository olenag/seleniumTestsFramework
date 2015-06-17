using System;
using System.Collections;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTestsProject
{
    
    public class GoogleNewsPageTests : TestBase
    {
        private GoogleNewsPage _googleNewsPage;
        
        [Test]
        public void Can_print_out_news_titles()
        {
            _googleNewsPage = OpenGoogleNewsPage(Driver);
            var titles = _googleNewsPage.FindNewsTitles();
            var newsTitlesprinted = _googleNewsPage.PrintTitles(titles);

            Assert.IsTrue(newsTitlesprinted);
        }

        [Test]
        public void Can_save_top_story_title_to_file()
        {
            _googleNewsPage = OpenGoogleNewsPage(Driver);
            var topStoryTitle = _googleNewsPage.TopStoryTitle;
            
            Assert.IsNotNullOrEmpty(topStoryTitle);

            var filePath = Environment.CurrentDirectory + @"\..\..\..\tools\TopStoryTitle.txt";
            File.WriteAllText(filePath, topStoryTitle);
        }

        
        private GoogleNewsPage OpenGoogleNewsPage(IWebDriver driver)
        {
            driver.Url = "https://news.google.com/";
            var googleNewsPage = new GoogleNewsPage(driver);
            googleNewsPage.Initialize();
            return googleNewsPage;
        }
    }
}

