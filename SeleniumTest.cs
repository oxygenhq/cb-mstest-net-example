﻿using CloudBeat.TDK.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace TestProject
{
    [TestClass]
    public class SeleniumTest : CBTest
    {
        private const string SITE_URL = @"http://automationpractice.com/index.php";

        public SeleniumTest() : base()
        {
        }

        [TestMethod]
        [TestCategory("purchase")]
        public void PurchaseDress()
        {
            var linkText = "DRESSES";
            _driver.Navigate().GoToUrl(SITE_URL);
            var link = _driver.FindElement(By.PartialLinkText(linkText));
            link.Click();
            StartStep("customStep");
            var link2 = _driver.FindElement(By.Id("layered_category_11"));
            link2.Click();

            var link3 = _driver.FindElement(By.PartialLinkText("Yellow"));
            link3.Click();
            EndStep("customStep");
            var link4 = _driver.FindElement(By.Id("layered_id_attribute_group_16"));
            link4.Click();
        }

        [TestMethod]
        [TestCategory("purchase")]
        public void PurchaseDress2()
        {
            var linkText = "DRESSES";
            _driver.Navigate().GoToUrl(SITE_URL);
            var link = _driver.FindElement(By.PartialLinkText(linkText));
            link.Click();

            var link2 = _driver.FindElement(By.Id("layered_category_11"));
            link2.Click();

            var link3 = _driver.FindElement(By.PartialLinkText("Yellow"));
            link3.Click();

            var link4 = _driver.FindElement(By.Id("layered_id_attribute_group_16"));
            link4.Click();
        }

        [TestMethod]
        [TestCategory("purchase")]
        public void PurchaseDress3()
        {
            var linkText = "DRESSES";
            _driver.Navigate().GoToUrl(SITE_URL);
            var link = _driver.FindElement(By.PartialLinkText(linkText));
            link.Click();

            var link2 = _driver.FindElement(By.Id("layered_category_sdawq11"));
            link2.Click();

            var link3 = _driver.FindElement(By.PartialLinkText("Yellow"));
            link3.Click();

            var link4 = _driver.FindElement(By.Id("layered_id_attribute_group_16"));
            link4.Click();
        }
    }
}
