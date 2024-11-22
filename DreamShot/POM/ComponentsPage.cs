using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamShot.POM
{
    public class ComponentsPage : BasePage

    {
        public ComponentsPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement CustomizeContainer => wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='main']/div/div[1]/div[3]/div[1]")));
        public IWebElement CustomizationMessage => wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='framer-1gewu0c']")));

        public IReadOnlyCollection<IWebElement> Cards => wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//div[contains(@name, 'Card') and not(contains(@name, 'Big'))]")));


        public override bool IsPageOpened()
        {
            ComponentsButton.Click();
            string path = "components";
            return driver.Url == Url + path;
        }

        public override void NavigateTo()
        {
            ComponentsButton.Click();
        }
    }
}
