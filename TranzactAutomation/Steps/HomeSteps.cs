using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TranzactAutomation.Pages;
using OpenQA.Selenium.Chrome;
using System;

namespace TranzactAutomation.Steps
{
    [Binding]
    public class HomeSteps : BasePage
    {
        
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private HomePage homepage;

        [BeforeScenario]
        public void BeforeScenario() 
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");

            string ChromePath = @"C:\Users\oslsa\source\repos\TranzactAutomation\TranzactAutomation\Drivers\";

            driver = new ChromeDriver(ChromePath, options);
            driver.Manage().Window.Maximize();
        }       

        [Given(@"User open website and is sent to login")]
        public void GivenUserOpenWebsite()
        {
            driver.Navigate().GoToUrl("https://demo.evershop.io/");
            homepage = new HomePage();
            homepage.clickLogin();
        }

        [Then(@"User access with new creadentials Email (.*) and Password (.*)")]
        public void ThenUserAccessWithNewCreadentialsEmailAndPassword(string user, string password)
        {
            homepage = new HomePage();
            homepage.clickLogin(); //Click on Login button from Homepage
        }
        
        [AfterScenario]
        public void AfterScenario() 
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
