using CloudBeat.TDK.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;

namespace MSTestExampleProject
{
    public class BaseTest : CBTest
    {
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }

        [TestInitialize()]
        public void Initialize()
        {
            _driver = new EventFiringWebDriver(new ChromeDriver());
            SubscribeToEvents();
        }

        [TestCleanup]
        public void Cleanup()
        {

        }
    }
}
