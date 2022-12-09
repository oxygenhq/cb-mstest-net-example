using System.Diagnostics;
using CloudBeat.TDK.MSTest.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace MSTestExampleProject
{
    [TestClass]
    public class UnitTest
    {
        public UnitTest()
        {
            Debugger.Launch();
        }
        [CbTestMethod]
        [TestCategory("test")]
        [Description("בדיקה")]
        public void TestMethod1()
        {
            /*var linkText = "DRESSES";
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            var link = _driver.FindElement(By.PartialLinkText(linkText));
            link.Click();

            StartStep("customStep");
            var link2 = _driver.FindElement(By.Id("layered_category_11"));
            link2.Click();
            var link3 = _driver.FindElement(By.PartialLinkText("Yellow"));
            link3.Click();
            EndStep("customStep");

            var link4 = _driver.FindElement(By.Id("layered_id_attribute_group_16"));
            link4.Click();*/
        }
    }
}
