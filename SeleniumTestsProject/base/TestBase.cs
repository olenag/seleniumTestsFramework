using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace SeleniumTestsProject
{
    [TestFixture]
    public abstract class TestBase
    {
        protected IWebDriver Driver;
        
        [TestFixtureSetUp]
        public virtual void BeforeAll()
        {
            Driver = CreateChromeDriver();
            Driver.Manage().Cookies.DeleteAllCookies();
        }

        [TestFixtureTearDown]
        public void AfterAll()
        {
            Driver.Quit();
        }

        [TearDown]
        public void AfterEachFailed()
        {

        }

        static IWebDriver CreateChromeDriver()
        {
            string chromeDriverPath = Environment.CurrentDirectory +@"\..\..\..\tools";

            DesiredCapabilities capability = DesiredCapabilities.Chrome();
            capability.SetCapability("applicationCacheEnabled", "false");
            return new ChromeDriver(chromeDriverPath);
        }

        static IWebDriver CreateFireFoxWebDriver()
        {
            DesiredCapabilities capability = DesiredCapabilities.Firefox();
            capability.SetCapability("applicationCacheEnabled", "false");
            return new FirefoxDriver();
        }

        
    }
}