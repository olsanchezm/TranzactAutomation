using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TranzactAutomation.Drivers;
using TranzactAutomation.Pages;

namespace TranzactAutomation.Steps
{
    [Binding]
    class ProductSteps : HomePage
    {
        private HomePage homepage;
        private MenPage manpage;
        private KidsPage kidspage;
        private WomenPage womenpage;
        private ProductPage productpage;
        [Then(@"add random products to cart")]
        public void ThenAddRandomProductsToCart()
        {
            homepage = new HomePage();
            homepage.clickMenProduct();

            manpage = new MenPage();
            manpage.SelectProductM(); //Selects a randon men's product

            productpage = new ProductPage();
            productpage.AddProduct();

            productpage.clickKidsLink();

            kidspage = new KidsPage();
            kidspage.SelectProductK(); //Selects a randon kids' product
            productpage.AddProduct();

            productpage.clickWomenLink();
            womenpage = new WomenPage();
            womenpage.SelectProductW(); //Selects a random women's product
            productpage.AddProduct();
        }
        [Then(@"User check cart")]
        public void ThenUserCheckCart()
        {
            Thread.Sleep(2000);
            productpage = new ProductPage();
            productpage.clickViewCart();
        }
    }
}
