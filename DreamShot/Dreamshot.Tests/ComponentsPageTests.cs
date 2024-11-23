using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamShot.NavigationTests
{
    public class ComponentsPageTests : TestSetup
    {

        [Test, Order(3)]
        public void Navigation_UserNavigatedTo_ComponentsPage()
        {
            componentsPage.NavigateTo();
            Assert.True(componentsPage.IsPageOpened(), "Components page is not opened");
        }

        [Test,Order(8)]
        public void ComponentsPage_NavBarButtonsArePresent()
        {
            Assert.True(componentsPage.AreElementsPresent(), "Navigation Bar buttons are not present on the page");
        }

        [Test,Order(9)]
        public void ComponentsPage_CustomizationContainerIsDisplayed()
        {
            actions.MoveToElement(componentsPage.CustomizeContainer).Perform();

            Assert.True(componentsPage.CustomizeContainer.Displayed, "Customization cards are not displayed");
        }

        [Test,Order(10)]
        public void ComponentsPage_CustomizationCardsContain_VisitButton()
        {
            actions.MoveToElement(componentsPage.CustomizationMessage).Perform();            

            foreach(var card in componentsPage.Cards)
            {
                Assert.That(card.Text.ToLower(), Does.Contain("visit"), "Cards do not contain the word visit");
            }
        }

        [Test,Order(11)]        
        public void SignUp_SignUpButtonColorIsAsExpected()
        {            
            string colorRgb = "rgba(255, 82, 79, 1)";

            actions.MoveToElement(componentsPage.SignUpBottomButton).Perform();
            string backgroundColor = componentsPage.SignUpBottomButton.GetCssValue("background-color");

            Assert.That(colorRgb, Is.EqualTo(backgroundColor), "Button color is not red as expected");

        }
    }
}
