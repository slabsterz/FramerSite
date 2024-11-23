using DreamShot.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamShot.Tests.MobileTests
{
    public class MobileTests
    {
        IWebDriver mobileDriver;

        [SetUp]
        public void SetUp()
        {
            var options = new ChromeOptions();
            options.EnableMobileEmulation("iPhone X");

            mobileDriver = new ChromeDriver(options);

            mobileDriver.Navigate().GoToUrl("https://mind-wend-913065.framer.app/");

        }

        [TearDown]
        public void TearDown()
        {
            mobileDriver.Quit();
            mobileDriver.Dispose();
        }

        [Test, Order(24)]
        public void TestMobileViewIphone()
        {
            IWebElement getAppButton = mobileDriver.FindElement(By.XPath("//div[@class='framer-1r7r56c-container']//span"));
            IWebElement watchVideoButton = mobileDriver.FindElement(By.XPath("//span[text()='Sign up']"));

            int getAppButtonY = getAppButton.Location.Y;
            int watchVideoButtonY = watchVideoButton.Location.Y;

            Assert.Less(watchVideoButtonY, getAppButtonY);
        }
    }
}
