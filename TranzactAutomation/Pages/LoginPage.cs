using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace TranzactAutomation.Pages
{    
    class LoginPage : BasePage
    {        
        private IWebElement txtEmail = driver.FindElement(By.XPath("//*[@name='email']"));
        private IWebElement txtPassword = driver.FindElement(By.XPath("//*[@name='password']"));
        private IWebElement btnSignIn = driver.FindElement(By.XPath("//*[text()='SIGN IN']"));
        private IWebElement btnCreateAccount = driver.FindElement(By.XPath("//a[text()='Create an account']"));
        public void Login(string email, string password)
        {
            TypeText(txtEmail, email);
            TypeText(txtPassword, password);
            ClickElement(btnSignIn);
            Thread.Sleep(3000);
        }
        public void ClickCreateAccount()
        {
            ClickElement(btnCreateAccount);
        }
    }
}
