using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace TranzactAutomation.Pages
{
    class KidsPage : BasePage
    {
        private List<IWebElement> listProductK = new List<IWebElement>(driver.FindElements(By.XPath("//*[contains(@class,'product-name product-list-name')]/a")));
        public void SelectProductK()
        {
            Thread.Sleep(2000);
            ClickElement(listProductK[productToSelect()]);
        }
        private static int productToSelect()
        {
            Random r = new Random();
            int element = r.Next(0, 2);
            Console.WriteLine("index: " + element);
            return element;
        }
    }
}
