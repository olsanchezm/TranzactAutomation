using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;

namespace TranzactAutomation.Pages
{
    public class OrderPage : BasePage
    {
        private IWebElement locatorName = driver.FindElement(By.XPath("//input[@name='address[full_name]']"));
        private IWebElement locatorTelephone = driver.FindElement(By.XPath("//input[@name='address[telephone]']"));
        private IWebElement locatorAddress_1 = driver.FindElement(By.XPath("//input[@name='address[address_1]']"));
        private IWebElement locatorCity = driver.FindElement(By.XPath("//input[@name='address[city]']"));
        private IWebElement locatorProvince = driver.FindElement(By.XPath("//select[@name='address[province]']"));
        private IWebElement locatorPostcode = driver.FindElement(By.XPath("//input[@name='address[postcode]']"));
        private IWebElement locatorContinue = driver.FindElement(By.XPath("//*[text()='Continue to payment']"));

        public void fillOrderData() 
        {
            locatorName.SendKeys(ScenarioContext.Current["orderName"].ToString());
            locatorTelephone.SendKeys(ScenarioContext.Current["orderEmail"].ToString());
            locatorAddress_1.SendKeys("33 Rodeo Street");
            locatorCity.SendKeys("Los Angeles");
            SelectElement dropdown = new SelectElement(locatorProvince);
            dropdown.SelectByValue("US-CA");
            locatorPostcode.SendKeys("90001");

            Thread.Sleep(2000);
            
            IWebElement locatorFreeShipping = driver.FindElement(By.XPath("//input[@type='radio']"));

            IJavaScriptExecutor ExecuteScript = (IJavaScriptExecutor)driver;
            ExecuteScript.ExecuteScript("arguments[0].click();", locatorFreeShipping);

            ClickElement(locatorContinue);
        }
    }
}
