using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace TranzactAutomation.Pages
{
    class WomenPage : BasePage
    {
        private List<IWebElement> listProductW = new List<IWebElement>(driver.FindElements(By.XPath("//*[contains(@class,'product-name product-list-name')]/a")));
        public void SelectProductW()
        {
            Thread.Sleep(2000);
            ClickElement(listProductW[productToSelect()]);
        }
        private static int productToSelect()
        {
            Random r = new Random();
            int element = r.Next(0, 2);            
            return element;
        }
    }
}
