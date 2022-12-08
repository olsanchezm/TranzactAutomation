using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Support;

namespace TranzactAutomation.Pages
{
    class HomePage : BasePage
    {
        IWebElement locatorUser => driver.FindElement(By.XPath("//*[@class='mini-cart-wrapper self-center']/following-sibling::*/a"));
        IWebElement locatorMenProduct => driver.FindElement(By.XPath("//*[@class='nav-link hover:underline' and text()='Men']"));
        public void clickLogin() 
        {
            ClickElement(locatorUser);
            Thread.Sleep(3000);
        }

        public void clickMenProduct() 
        {            
            Thread.Sleep(5000);
            ClickElement(locatorMenProduct);            
        }
    }
}