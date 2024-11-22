using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamShot.NavigationTests
{
    public class SignUpPageTests : TestSetup
    {
        [Test, Order(1)]
        public void SignUp_NavBarButtonsArePresent()
        {
            signUpPage.NavigateTo();
            Assert.True(signUpPage.AreElementsPresent(), "Navigation Bar buttons are not present on the page");
        }

        
    }
}
