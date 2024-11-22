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
        [Test, Order(8)]
        public void PricingPage_NavBarButtonsArePresent()
        {
            pricingPage.NavigateTo();
            Assert.True(pricingPage.AreElementsPresent(), "Navigation Bar buttons are not present on the page");
        }

        [Test, Order(9)]
        public void PricingPage_PlansIncludeDollarSymbol()
        {
            pricingPage.NavigateTo();

            foreach(var pricingElement in pricingPage.PlanPrice)
            {
                Assert.That(pricingElement.Text, Does.Contain("$"), "Pricing does not contain $ symbol");
            }
        }

        [Test, Order(10)]
        public void PricingPage_TotalNumberOfPlansIsCorrect()
        {
            int planCounter = 0;
            pricingPage.NavigateTo();

            foreach (var pricingElement in pricingPage.Plans)
            {
                planCounter++;
            }

            Assert.That(planCounter, Is.EqualTo(3), "The total payment plans are not 3");
        }

        [Test, Order(11)]
        public void PricingPage_FaqSectionIsVisible()
        {
            pricingPage.NavigateTo();
            actions.MoveToElement(pricingPage.FaqSection).Perform();

            Assert.True(pricingPage.FaqSection.Displayed);
        }

        [Test, Order(12)]
        public void PricingPage_FaqSection_DoesContainFourQuestions()
        {
            pricingPage.NavigateTo();
            actions.MoveToElement(pricingPage.FaqSection).Perform();

            Assert.That(pricingPage.Questions.Count, Is.EqualTo(4));
            
        }
    }
}
