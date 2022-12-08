using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TranzactAutomation.Pages
{
    class RegisterPage : BasePage
    {
        IWebElement txtFullName = driver.FindElement(By.XPath("//*[@name='full_name']"));
        IWebElement txtEmail = driver.FindElement(By.XPath("//*[@name='email']"));
        IWebElement txtPassword = driver.FindElement(By.XPath("//*[@name='password']"));        
        IWebElement btnSignUp = driver.FindElement(By.XPath("//*[text()='SIGN UP']"));
        
        public void CreateAccount(string name, string email, string password)
        {
            TypeText(txtFullName, name);
            TypeText(txtEmail, email);
            ScenarioContext.Current["orderName"] = name;
            ScenarioContext.Current["orderEmail"] = email;
            TypeText(txtPassword, password);
            ClickElement(btnSignUp);            
        }
    }
}
