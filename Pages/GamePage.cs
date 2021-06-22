using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SparkwareTest.Pages
{
    class GamePage: DriverHelper
    {
        public WebDriverWait Wait { get; set; } = new WebDriverWait(Driver, new TimeSpan(0, 0, 60));
        public IWebElement OKButton => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("gameCanvas")));
        public IWebElement SpinButton => Driver.FindElement(By.ClassName("spin_button"));

        private void ConfirmGameFrame()
        {
            OKButton.Click();
        }
        public void SpinOneTime()
        {
            //ConfirmGameFrame();
            SpinButton.Click();
        }
    }
}
