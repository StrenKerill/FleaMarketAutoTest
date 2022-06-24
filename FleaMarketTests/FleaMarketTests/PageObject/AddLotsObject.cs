using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FleaMarketTests.PageObject
{
    class AddLotsObject
    {
        private IWebDriver _webDriver;

        private readonly By _name = By.XPath("//input[@placeholder='Name']");
        private const string _writeName = "Тест";

        private readonly By _description = By.XPath("//textarea[@name='Description']");
        private const string _writeDesc = "Тестовое описание товара";

        public AddLotsObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void AddLotts()
        {
            _webDriver.FindElement(_name).SendKeys(_writeName);
            _webDriver.FindElement(_description).SendKeys(_writeDesc);
        }
    }
}
