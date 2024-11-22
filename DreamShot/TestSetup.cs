using DreamShot.POM;
using DreamShot.Tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace DreamShot
{
    public class TestSetup
    {

        protected IWebDriver driver;
        public WebDriverWait wait;
        public Actions actions;
        public readonly string Url = "https://mind-wend-913065.framer.app";

        public BasePage basePage;
        public ComponentsPage componentsPage;
        public PricingPage pricingPage;
        public UpdatesPage updatesPage;
        public SignUpPage signUpPage;

        [OneTimeSetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArgument("--disable-search-engine-choice-screen");            
            
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            driver.Navigate().GoToUrl(Url);

            actions = new Actions(driver);

            basePage = new BasePage(driver);
            componentsPage = new ComponentsPage(driver);
            pricingPage = new PricingPage(driver);
            updatesPage = new UpdatesPage(driver);
            signUpPage = new SignUpPage(driver);

        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
        
    }
}