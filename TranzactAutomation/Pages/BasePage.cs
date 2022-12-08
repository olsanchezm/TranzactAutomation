
using System;
using System.Collections.Generic;
using System.Text;
using TranzactAutomation.Drivers;
using OpenQA.Selenium;

namespace TranzactAutomation.Pages
{
    public class BasePage : DriverHelper
    {        

        public void ClickElement(IWebElement element)
        {
            element.Click();
        }

        public void TypeText(IWebElement element, String text) 
        {
            element.SendKeys(text);
        }
    }   
}
