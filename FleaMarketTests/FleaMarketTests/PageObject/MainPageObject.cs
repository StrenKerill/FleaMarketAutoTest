using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FleaMarketTests.PageObject
{
    class MainPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _myPagePhoneNumber = By.XPath("//a[@id='dropdownUser2']");

        private readonly By _myPage = By.XPath("//a[text()='Моя страница']");

        private readonly By _goLots = By.XPath("//a[@onclick='Product_extension()']");

        private readonly By _goCategory = By.XPath("//a[@class='btn btn-primary shadow-primary btn-lg dropdown']");

        private readonly By _nullCategory = By.XPath("//option[@value='-1']");

        private readonly By _goState = By.XPath("//select[@placeholder='CityId']");

        private readonly By _allState = By.XPath("//option[@value='-1']");

        private readonly By _find = By.XPath("//input[@class='form - control form - control - lg rounded - 0']");

        private const string _writeFind = "Iwrit Ewrei4";

        private readonly By _addLots = By.XPath("//a[@onclick='Product_extension()']");

        public MainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AddLotsObject AddLots()
        {
            _webDriver.FindElement(_addLots).Click();
            return new AddLotsObject(_webDriver);
        }

        public void Find()
        {
            Thread.Sleep(400);
            _webDriver.FindElement(_find).SendKeys(_writeFind);
        }
    }
}
