using DreamShot.POM;
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
    public class PricingPageTests : TestSetup
    {

        [Test, Order(11)]
        public void PricingPage_Navigation_UserNavigatedTo_PricingPage()
        {
            pricingPage.NavigateTo();
            Assert.True(pricingPage.IsPageOpened(), "Pricing page is not opened");
        }

        [Test, Order(12)]
        public void PricingPage_NavBarButtonsArePresent()
        {
            Assert.True(pricingPage.AreElementsPresent(), "Navigation Bar buttons are not present on the page");
        }

        [Test, Order(13)]
        public void PricingPage_PlansIncludeDollarSymbol()
        {
            foreach(var pricingElement in pricingPage.PlanPrice)
            {
                Assert.That(pricingElement.Text, Does.Contain("$"), "Pricing does not contain $ symbol");
            }
        }

        [Test, Order(14)]
        public void PricingPage_TotalNumberOfPlansIsCorrect()
        {
            int planCounter = 0;

            foreach (var pricingElement in pricingPage.Plans)
            {
                planCounter++;
            }

            Assert.That(planCounter, Is.EqualTo(3), "The total payment plans are not 3");
        }

        [Test, Order(15)]
        public void PricingPage_FaqSectionIsVisible()
        {
            actions.MoveToElement(pricingPage.FaqSection).Perform();

            Assert.True(pricingPage.FaqSection.Displayed, "FAQ section is not displayed");
        }

        [Test, Order(16)]
        public void PricingPage_FaqSection_DoesContainFourQuestions()
        {            
            actions.MoveToElement(pricingPage.FaqSection).Perform();

            Assert.That(pricingPage.Questions.Count, Is.EqualTo(4), "Questions in FAQ are not 4");
            
        }
    }
}
