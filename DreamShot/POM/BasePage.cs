using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DreamShot.POM
{  

    public class BasePage 
    {

        public IWebDriver driver;
        public WebDriverWait wait;
        public readonly string Url = "https://mind-wend-913065.framer.app/";

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }       

        public IWebElement HomeButton => driver.FindElement(By.XPath("//a[@class='framer-dh83y1']"));
        public IWebElement ComponentsButton => driver.FindElement(By.XPath("//p[@class='framer-styles-preset-kqguaa']//span[text()='Components']"));
        public IWebElement PricingButton => driver.FindElement(By.XPath("//p[@class='framer-styles-preset-kqguaa']//span[text()='Pricing']"));
        public IWebElement UpdatesButton => driver.FindElement(By.XPath("//p[@class='framer-styles-preset-kqguaa']//span[text()='Updates']"));
        public IWebElement SignUpButton => driver.FindElement(By.XPath("//p[@class='framer-styles-preset-9us7yb']//span[text()='Sign up']"));

        public IWebElement SignUpBottomButton => driver.FindElement(By.XPath("//input[@type='submit' and @value='Sign Up']"));

        public IWebElement GetTheAppButton => driver.FindElement(By.XPath("//div[@class='framer-14g223s rich-text-wrapper']//p//span"));
        public IWebElement WatchVideoButton => driver.FindElement(By.XPath("//div[@class='framer-wq259l undefined watch-video-button']//p//span"));

        public IWebElement Open3dImageButton => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='framer-8nn08p 3D-button']")));
        public IWebElement BackgroundImage => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='framer-1sws33j 3DComponent']")));
        public IWebElement CanvasElement => wait.Until(ExpectedConditions.ElementIsVisible(By.Id("canvas3d")));

        public IWebElement blurredElement => driver.FindElement(By.XPath("//div[@id='overlay']"));

        public bool AreElementsPresent()
        {
            return HomeButton.Displayed &&
               ComponentsButton.Displayed &&
               PricingButton.Displayed &&
               UpdatesButton.Displayed &&
               SignUpButton.Displayed;
        }

        public virtual bool IsPageOpened()
        {
            HomeButton.Click();
            return driver.Url == this.Url;
        }

        public virtual void NavigateTo()
        {
            HomeButton.Click();
        }
    }
}
