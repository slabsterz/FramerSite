using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamShot.NavigationTests
{
    public class BasePageTests : TestSetup
    {
        [Test, Order(5)]
        public void BasePage_NavBarElementsArePresent()
        {
            Assert.True(basePage.AreElementsPresent(), "Navigation Bar buttons are not present on the page");
        }

        [Test, Order(6)]
        public void BasePage_ImagesGetsBlurry_AfterGetTheAppIsClicked()
        {
            basePage.GetTheAppButton.Click();

            Assert.IsTrue(basePage.blurredElement.Displayed, "The overlay did not become visible after the blur effect was triggered.");
        }

        [Test, Order(7)]
        public void BasePage_3dAnimationIsDisplayed()
        {
            driver.Navigate().GoToUrl("https://mind-wend-913065.framer.app/");

            Assert.True(basePage.BackgroundImage.Displayed, "Background image is not displayed");

            actions.MoveByOffset(960, 540).Perform();

            Assert.True(basePage.Open3dImageButton.Displayed, "Open 3D image button is not displayed");

            basePage.Open3dImageButton.Click();

            var iframeElement = driver.FindElement(By.XPath("//iframe[@src='https://my.spline.design/framercopy-bd9e7275da55ebaf7252e8a0e4e0055f/']"));
            driver.SwitchTo().Frame(iframeElement);

            Assert.IsTrue(basePage.CanvasElement.Displayed, "The 3D canvas inside the iframe is not visible.");

            string width = basePage.CanvasElement.GetAttribute("width");
            string height = basePage.CanvasElement.GetAttribute("height");

            Assert.IsTrue(int.Parse(width) > 0, "Canvas width is not set correctly.");
            Assert.IsTrue(int.Parse(height) > 0, "Canvas height is not set correctly.");

            driver.SwitchTo().DefaultContent();

        }

    }
}
