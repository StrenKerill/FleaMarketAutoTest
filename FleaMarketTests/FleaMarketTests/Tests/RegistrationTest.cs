using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using FleaMarketTests.PageObject;
using System.Threading;
using FleaMarketTests.BaseTests;

namespace FleaMarketTests.Tests
{
    public class RegistrationTest : BaseTest
    {
        [Test]
        public void RegistrationUserTest()
        {
            var registration = new AuthorizationPageObject(_webDriver);
            registration
                .Reg()
                .SignIn();
        }
    }
}
