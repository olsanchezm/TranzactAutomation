using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TranzactAutomation.Drivers;
using TranzactAutomation.Pages;

namespace TranzactAutomation.Steps
{
    [Binding]
    public class LoginSteps: DriverHelper
    {
        private LoginPage loginpage;

        [When(@"User access to register page")]
        public void ThenUserAccessToRegisterPage()
        {
            loginpage = new LoginPage();
            loginpage.ClickCreateAccount(); //Click on Create Account in Login Page
        }
    }
}
