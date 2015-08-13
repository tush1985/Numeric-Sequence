using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberSequence.Models;
using TestStack.Seleno.PageObjects.Locators;

namespace NumberSequence.Tests
{
    [TestFixture]
    public class SequenceNumericFunctionalUITest
    {
        [Test]
        public void ShouldGetNumbers()
        {
            BrowserHost.Instance.Application.Browser
                .Navigate()
                .GoToUrl(BrowserHost.RootURL + @"Home\Index");
            var UserValue = BrowserHost.Instance.Application.Browser.FindElement(By.Id("uservalue"));
            UserValue.SendKeys("10");

            var GetValues = BrowserHost.Instance.Application.Browser.FindElement(By.Id("getvalues"));
            GetValues.Click();

            var acceptmessagetext = BrowserHost.Instance.Application.Browser.FindElement(By.Id("message"));

            Assert.That(acceptmessagetext.Text, Is.EqualTo("success")); 
        }
    }
}
