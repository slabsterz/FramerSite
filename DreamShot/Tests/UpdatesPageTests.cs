using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamShot.NavigationTests
{
    public class UpdatesPageTests : TestSetup
    {
        [Test, Order(18)]
        public void UpdatesPage_NavBarButtonsArePresent()
        {
            updatesPage.NavigateTo();
            Assert.True(updatesPage.AreElementsPresent(), "Navigation Bar buttons are not present on the page");
        }

        [Test, Order(19)]
        public void UpdatesPage_UpdatesHeaderIsVisible()
        {
            Assert.True(updatesPage.UpdatesHeader.Displayed, "Updates header is not displayed");
        }
    }
}
