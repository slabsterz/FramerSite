using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamShot.NavigationTests
{
    public class NavigationTests : TestSetup
    {
        [Test, Order(1)]
        public void Navigation_UserNavigatedToBasePage_WhenWebSiteIsOpened()
        {
            string expectedUrl = "https://mind-wend-913065.framer.app/";

            Assert.That(driver.Url, Is.EqualTo(expectedUrl), "Base page not opened");
        }

        [Test, Order(2)]
        public void Navigation_NavBarIsDisplayed_WhenPageOpened()
        {
            Assert.True(basePage.AreElementsPresent(), "Navigation Bar is not displayed on base page");
        }

        [Test, Order(4)]
        public void Navigation_UserNavigatedTo_HomePage()
        {
            basePage.NavigateTo();
            Assert.True(basePage.IsPageOpened(), "Home page is not opened");
        }

        [Test, Order(3)]
        public void Navigation_UserNavigatedTo_ComponentsPage()
        {
            componentsPage.NavigateTo();
            Assert.True(componentsPage.IsPageOpened(), "Components page is not opened");
        }

        [Test, Order(5)]
        public void Navigation_UserNavigatedTo_PricingPage()
        {
            pricingPage.NavigateTo();
            Assert.True(pricingPage.IsPageOpened(), "Pricing page is not opened");
        }

        [Test, Order(6)]
        public void Navigation_UserNavigatedTo_UpdatesPage()
        {
            Assert.True(updatesPage.IsPageOpened(), "Updates page is not opened");
        }

        [Test, Order(7)]
        public void Navigation_UserNavigatedTo_SignUpPage()
        {
            Assert.True(signUpPage.IsPageOpened(), "Sign Up page is not opened");
        }
    }
}
