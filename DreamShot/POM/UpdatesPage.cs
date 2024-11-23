using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamShot.POM
{
    public class UpdatesPage : BasePage
    {
        public UpdatesPage(IWebDriver driver) : base(driver)
        {            
        }

        public IWebElement UpdatesHeader => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h1//span[text()='Updates']")));

        public override bool IsPageOpened()
        {
            UpdatesButton.Click();
            string path = "updates";
            return driver.Url == Url + path;
        }

        public override void NavigateTo()
        {
            UpdatesButton.Click();
        }
    }
}
