using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamShot.NavigationTests
{
    public class UpdatesPageTests : TestSetup
    {

        [Test, Order(17)]
        public void UpdatesPage_Navigation_UserNavigatedTo_UpdatesPage()
        {
            updatesPage.NavigateTo();
            Assert.True(updatesPage.IsPageOpened(), "Updates page is not opened");
        }

        [Test, Order(18)]
        public void UpdatesPage_NavBarButtonsArePresent()
        {
            Assert.True(updatesPage.AreElementsPresent(), "Navigation Bar buttons are not present on the page");
        }

        [Test, Order(19)]
        public void UpdatesPage_UpdatesHeaderIsVisible()
        {
            Assert.True(updatesPage.UpdatesHeader.Displayed, "Updates header is not displayed");
        }
    }
}
