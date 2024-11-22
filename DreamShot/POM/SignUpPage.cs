using OpenQA.Selenium;
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
