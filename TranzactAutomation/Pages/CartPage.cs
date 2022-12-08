using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TranzactAutomation.Pages
{
    class CartPage : BasePage
    {
        private IWebElement locatorCheck => driver.FindElement(By.XPath("//*[@class='shopping-cart-checkout-btn flex justify-between mt-2']/a"));
        private IWebElement locatorSubtotal => driver.FindElement(By.XPath("//*[text()='Sub total']/following-sibling::*"));
        public void clickCheckOut() 
        {
            ScenarioContext.Current["orderSubtotal"] = locatorSubtotal.Text;         
            ClickElement(locatorCheck);
        }
    }
}
