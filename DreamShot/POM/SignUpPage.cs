using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamShot.POM
{
    public class SignUpPage : BasePage
    {
        public SignUpPage(IWebDriver driver) : base(driver)
        {            
        }

        public IWebElement SignUpForm => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@data-projection-id='40']")));

        public override bool IsPageOpened()
        {
            SignUpButton.Click();
            string path = "signup";
            return driver.Url == Url + path;
        }

        public override void NavigateTo()
        {
            SignUpButton.Click();
        }
    }
}
