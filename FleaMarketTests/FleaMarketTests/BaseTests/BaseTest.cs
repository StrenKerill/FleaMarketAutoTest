using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;

namespace FleaMarketTests.BaseTests
{
    public class BaseTest
    {
        protected IWebDriver _webDriver;

        [OneTimeSetUp]
        protected void DoBeforeAllTheTests()
        {
            _webDriver = new ChromeDriver();
        }

        //[TearDown]
        //protected void DoAfterEach()
        //{
        //    _webDriver.Quit();
        //}

        [SetUp]
        protected void DoBeforeEach()
        {
            _webDriver.Navigate().GoToUrl(TestSetting.LocationFleaMarket);
            _webDriver.Manage().Window.Maximize();
        }
    }
}
