using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FleaMarketTests.PageObject
{
    class RegistrationPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _selectState = By.XPath("//select[@name='CityId']");

        private readonly By _enter = By.XPath("//input[@value='Зарегистрироваться']");

        private const string _phoneNumber = "9076664435";
        private readonly By _fieldPhoneNumber = By.XPath("//input[@name='PhoneNumber']");

        private const string _password = "12345678";
        private const string _negativPassword = "'/@,.test";
        private readonly By _fieldPassword = By.XPath("//input[@name='Password']");

        private const string _nameUser = "Вадим";
        private readonly By _fieldName = By.XPath("//input[@name='Name']");

        private const string _surnameUser = "Комиссаров";
        private readonly By _fieldSurname = By.XPath("//input[@class='form-control']");

        private readonly By _stateUser = By.XPath("//option[@value='1']");

        public RegistrationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainPageObject SignIn()
        {

            Thread.Sleep(400);
            _webDriver.FindElement(_fieldPhoneNumber).SendKeys(_phoneNumber);

            Thread.Sleep(400);
            _webDriver.FindElement(_fieldName).SendKeys(_nameUser);

            Thread.Sleep(400);
            _webDriver.FindElement(_fieldSurname).SendKeys(_surnameUser);

            Thread.Sleep(400);
            _webDriver.FindElement(_fieldPassword).SendKeys(_password);

            Thread.Sleep(400);
            _webDriver.FindElement(_selectState).Click();
            Thread.Sleep(400);
            _webDriver.FindElement(_stateUser).Click();

            Thread.Sleep(400);
            _webDriver.FindElement(_enter).Click();

            return new MainPageObject(_webDriver);
        }

        public MainPageObject NegativSignIn()
        {
            Thread.Sleep(400);
            _webDriver.FindElement(_fieldPhoneNumber).SendKeys(_phoneNumber);

            Thread.Sleep(400);
            _webDriver.FindElement(_fieldName).SendKeys(_nameUser);

            Thread.Sleep(400);
            _webDriver.FindElement(_fieldSurname).SendKeys(_surnameUser);

            Thread.Sleep(400);
            _webDriver.FindElement(_fieldPassword).SendKeys(_negativPassword);

            Thread.Sleep(400);
            _webDriver.FindElement(_enter).Click();

            return new MainPageObject(_webDriver);
        }
    }
}
