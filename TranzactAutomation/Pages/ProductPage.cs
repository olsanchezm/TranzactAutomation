using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace TranzactAutomation.Pages
{
    
    class ProductPage : BasePage
    {
        private IWebElement locatorKidsProduct => driver.FindElement(By.XPath("//*[@class='nav-link hover:underline' and text()='Kids']"));
        private IWebElement locatorWomenProduct => driver.FindElement(By.XPath("//*[@class='nav-link hover:underline' and text()='Women']"));
        private IWebElement locatorAddProduct => driver.FindElement(By.XPath("//span[text()='ADD TO CART']"));
        private IWebElement locatorViewCart => driver.FindElement(By.ClassName("add-cart-popup-button"));
        private IWebElement locatorQuantity => driver.FindElement(By.XPath("//*[@type='text']"));

        private List<IWebElement> listProductK = new List<IWebElement>(driver.FindElements(By.XPath("//*[contains(@class,'product-name product-list-name')]")));
        private List<IWebElement> listProductW = new List<IWebElement>(driver.FindElements(By.XPath("//*[contains(@class,'product-name product-list-name')]")));
               

        internal void AddProduct()
        {            
            bool flagSize = false;
            bool flagColor = false;
            
            //Select Size if available
            if (driver.FindElements(By.XPath("//a[text()='S']")).Count != 0) {
                ClickElement(driver.FindElement(By.XPath("//a[text()='S']"))); flagSize = true;
            }
            else {
                if (driver.FindElements(By.XPath("//a[text()='M']")).Count != 0 && flagSize == false) {
                    ClickElement(driver.FindElement(By.XPath("//a[text()='M']"))); flagSize = true;
                }
                else {
                    if (driver.FindElements(By.XPath("//a[text()='L']")).Count != 0 && flagSize == false) {
                        ClickElement(driver.FindElement(By.XPath("//a[text()='L']"))); flagSize = true;
                    }
                    else {
                        if (driver.FindElements(By.XPath("//a[text()='XL']")).Count != 0 && flagSize == false) {
                            ClickElement(driver.FindElement(By.XPath("//a[text()='XL']"))); flagSize = true;
                        }
                        else {
                            flagSize = true;
                        }
                    }
                }
            }

            //Select Color if available
            if (driver.FindElements(By.XPath("//a[text()='White']")).Count != 0)
            {
                ClickElement(driver.FindElement(By.XPath("//a[text()='White']"))); flagColor = true;
            }
            else
            {
                if (driver.FindElements(By.XPath("//a[text()='Black']")).Count != 0 && flagColor == false)
                {
                    ClickElement(driver.FindElement(By.XPath("//a[text()='Black']"))); flagColor = true;
                }
                else
                {
                    if (driver.FindElements(By.XPath("//a[text()='Blue']")).Count != 0 && flagColor == false)
                    {
                        ClickElement(driver.FindElement(By.XPath("//a[text()='Blue']"))); flagColor = true;
                    }
                    else
                    {
                        if (driver.FindElements(By.XPath("//a[text()='Red']")).Count != 0 && flagColor == false)
                        {
                            ClickElement(driver.FindElement(By.XPath("//a[text()='Red']"))); flagColor = true;
                        }
                        else
                        {
                            if (driver.FindElements(By.XPath("//a[text()='Pink']")).Count != 0 && flagColor == false)
                            {
                                ClickElement(driver.FindElement(By.XPath("//a[text()='Pink']"))); flagColor = true;
                            }
                            else
                            {
                                if (driver.FindElements(By.XPath("//a[text()='Brown']")).Count != 0 && flagColor == false)
                                {
                                    ClickElement(driver.FindElement(By.XPath("//a[text()='Brown']"))); flagColor = true;
                                }
                                else
                                {
                                    flagColor = true;
                                }
                            }
                        }
                    }
                }                
            }
            //Select random quantity
            TypeText(locatorQuantity, quantityToAdd().ToString());

            ClickElement(locatorAddProduct);
        }

        public void clickKidsLink()
        {
            Thread.Sleep(2000);
            ClickElement(locatorKidsProduct);
            Thread.Sleep(3000);
        }
        public void clickWomenLink()
        {
            Thread.Sleep(2000);
            ClickElement(locatorWomenProduct);
            Thread.Sleep(3000);
        }
        public void clickViewCart() 
        {
            Thread.Sleep(3000);
            ClickElement(locatorViewCart);
        }
        private static int quantityToAdd()
        {
            Random r = new Random();
            return r.Next(1, 5);
        }        
    }
}
