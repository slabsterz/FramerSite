using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DreamShot.POM
{
    public class PricingPage : BasePage
    {
        public PricingPage(IWebDriver driver) : base(driver)
        {            
        }


        public IWebElement PriceContainer => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='main']/div/div[1]/div[2]/div[5]")));

        public IReadOnlyCollection<IWebElement> Plans => PriceContainer.FindElements(By.XPath(".//div[contains(@values, 'object Object')]"));

        public IReadOnlyCollection<IWebElement> PlanPrice => wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='main']/div/div[1]/div[2]/div[5]//h2")));

        public IWebElement FaqSection => driver.FindElement(By.XPath("//*[@id='main']/div/div[1]/div[4]/div[2]"));

        public IReadOnlyCollection<IWebElement> Questions => FaqSection.FindElements(By.XPath(".//div[contains(@values, 'object Object')]"));


        public override bool IsPageOpened()
        {
            PricingButton.Click();
            string path = "pricing";
            return driver.Url == Url + path;
        }

        public override void NavigateTo()
        {
            PricingButton.Click();
        }
    }
}
