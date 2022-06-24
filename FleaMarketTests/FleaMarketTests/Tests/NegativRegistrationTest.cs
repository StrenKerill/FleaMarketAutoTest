using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using FleaMarketTests.PageObject;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Edge;
using FleaMarketTests.BaseTests;

namespace FleaMarketTests.Tests
{
    public class NegativRegistrationTest : BaseTest
    {
        [Test]
        public void NegativRegistrationUserTest()
        {
            var negativreg = new AuthorizationPageObject(_webDriver)
                .Reg()
                .NegativSignIn();
        }
    }
}
