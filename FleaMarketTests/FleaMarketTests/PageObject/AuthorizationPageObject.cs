using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FleaMarketTests.PageObject
{
    class AuthorizationPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _fieldPhoneNumber = By.XPath("//input[@name='PhoneNumber']");
        private const string _phoneNumber = "9076664435";

        private readonly By _fieldPassword = By.XPath("//input[@name='Password']");
        private const string _password = "12345678";
        private const string _negativPassword = ".,/@'asdasdsad";
        private const string _dbHackPassword = "DROB DATABASE";
        private const string _xssAtackPassword = "<script>/*Malicious code*/</script>";

        private readonly By _enter = By.XPath("//input[@value='Войти']");

        private readonly By _regButton = By.XPath("//a[@href='/Account/Register']");

        public AuthorizationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public RegistrationPageObject Reg()
        {
            _webDriver.FindElement(_regButton).Click();

            return new RegistrationPageObject(_webDriver);
        }

        public MainPageObject AuthorizationUser()
        {
            _webDriver.FindElement(_fieldPhoneNumber).SendKeys(_phoneNumber);

            Thread.Sleep(400);
            _webDriver.FindElement(_fieldPassword).SendKeys(_password);

            Thread.Sleep(400);
            _webDriver.FindElement(_enter).Click();

            return new MainPageObject(_webDriver);
        }

        public MainPageObject AuthorizationDbHack()
        {
            _webDriver.FindElement(_fieldPhoneNumber).SendKeys(_phoneNumber);

            Thread.Sleep(400);
            _webDriver.FindElement(_fieldPassword).SendKeys(_dbHackPassword);

            Thread.Sleep(400);
            _webDriver.FindElement(_enter).Click();

            return new MainPageObject(_webDriver);
        }

        public MainPageObject AuthorizationXssAtack()
        {
            _webDriver.FindElement(_fieldPhoneNumber).SendKeys(_phoneNumber);

            Thread.Sleep(400);
            _webDriver.FindElement(_fieldPassword).SendKeys(_xssAtackPassword);

            Thread.Sleep(400);
            _webDriver.FindElement(_enter).Click();

            return new MainPageObject(_webDriver);
        }

        public MainPageObject NegativAuthorizationUser()
        {
            _webDriver.FindElement(_fieldPhoneNumber).SendKeys(_phoneNumber);

            Thread.Sleep(400);
            _webDriver.FindElement(_fieldPassword).SendKeys(_negativPassword);

            Thread.Sleep(400);
            _webDriver.FindElement(_enter).Click();

            return new MainPageObject(_webDriver);
        }
    }
}
