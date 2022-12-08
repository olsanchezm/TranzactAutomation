using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace TranzactAutomation.Pages
{
    class MenPage: BasePage
    {
        private List<IWebElement> listProductM = new List<IWebElement>(driver.FindElements(By.XPath("//*[contains(@class,'product-name product-list-name')]/a")));
        public void SelectProductM() 
        {
            ClickElement(listProductM[productToSelect()]);
        }
        private static int productToSelect() 
        {            
            Random r = new Random();
            return r.Next(0, 2);
        }
    }
}
