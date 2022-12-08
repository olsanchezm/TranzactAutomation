using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TranzactAutomation.Drivers;
using TranzactAutomation.Pages;

namespace TranzactAutomation.Steps
{
    [Binding]
    class orderSteps
    {
        private CartPage cartpage;
        private OrderPage orderpage;
        private CheckOutPage checkoutpage;
        [Then(@"User starts checkout")]
        public void ThenUserStartsCheckout()
        {
            cartpage = new CartPage();
            cartpage.clickCheckOut();
        }

        [Then(@"User fill shipping information")]
        public void ThenUserFillShippingInformation()
        {
            orderpage = new OrderPage();
            orderpage.fillOrderData();
        }
        [Then(@"User pay order")]
        public void ThenUserPayProducts()
        {
            checkoutpage = new CheckOutPage();
            checkoutpage.payOrder();

            Assert.AreEqual(checkoutpage.validateOrder(), true); 
        }
    }
}
