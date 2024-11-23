using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamShot.NavigationTests
{
    public class SignUpPageTests : TestSetup
    {

        [Test, Order(20)]
        public void Navigation_UserNavigatedTo_SignUpPage()
        {
            signUpPage.NavigateTo();
            Assert.True(signUpPage.IsPageOpened(), "Sign Up page is not opened");
        }

        [Test, Order(21)]
        public void SignUpPage_NavBarButtonsArePresent()
        {
            Assert.True(signUpPage.AreElementsPresent(), "Navigation Bar buttons are not present on the page");
        }

        [Test, Order(22)]
        public void SignUpPage_SignUpFormIsDisplayed()
        {
            Assert.True(signUpPage.SignUpForm.Displayed, "Sign Up form is not displayed");
        }
        
    }
}
