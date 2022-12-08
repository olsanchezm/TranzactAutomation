using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;

namespace TranzactAutomation.Pages
{
    class CheckOutPage : BasePage
    {
        public void payOrder()
        {
            Thread.Sleep(3000);

            IWebElement locatorPayment = driver.FindElement(By.XPath("//input[@id='methodCode0']"));
            IJavaScriptExecutor ExecuteScript = (IJavaScriptExecutor)driver;
            ExecuteScript.ExecuteScript("arguments[0].click();", locatorPayment);

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//iframe[contains(@name,'privateStripe')]")).Click();
            driver.SwitchTo().Frame(0);

            IWebElement locatorCardNumber = driver.FindElement(By.XPath("//input[@name='cardnumber']"));//
            IWebElement locatorExpDate = driver.FindElement(By.XPath("//input[@name='exp-date']"));
            IWebElement locatorCVC = driver.FindElement(By.XPath("//input[@name='cvc']"));

            locatorCardNumber.SendKeys("4242424242424242");
            locatorExpDate.SendKeys("0424");
            locatorCVC.SendKeys("242");

            driver.SwitchTo().ParentFrame();
            IWebElement locatorPlaceOrder = driver.FindElement(By.XPath("//button[@class='button primary']"));

            ClickElement(locatorPlaceOrder);

            Thread.Sleep(5000);
        }

        public bool validateOrder()
        {
            IWebElement valSubTotal = driver.FindElement(By.XPath("//div/span[text()='Total']/following-sibling::*/div/following-sibling::*"));
            IWebElement valEmail = driver.FindElement(By.XPath("//*[text()='Contact information']/following-sibling::*"));
            IWebElement valShipping = driver.FindElement(By.XPath("//*[text()='Shipping Address']/following-sibling::*"));
            IWebElement valBilling = driver.FindElement(By.XPath("//*[text()='Billing Address']/following-sibling::*"));

            bool flag = true;
            if (valSubTotal.Text != ScenarioContext.Current["orderSubtotal"].ToString()) { flag = false; }
            if (valEmail.Text != ScenarioContext.Current["orderEmail"].ToString()) { flag = false; }
            if (valShipping.Text != valBilling.Text) { flag = false; }

            return flag;
        }
    }
}
