using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using UtilitaEnergy.Webpage.Pages;

namespace UtilitaEnergy.Webpage.Steps
{
    [Binding]
    class OrderHistoryStep
    {
        OrderHistoryPage page = null;
        IWebDriver _driver = DriverHelper.Driver;

        [Then(@"confirm the Item is present")]
        public void ThenConfirmTheItemIsPresent()
        {
            page = new OrderHistoryPage(_driver);
            page.OrderHistoryConfirm();
        }
    }
}
