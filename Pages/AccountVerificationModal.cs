using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SparkwareTest.Pages
{
    class AccountVerificationModal: DriverHelper
    {
        public WebDriverWait Wait { get; set; } = new WebDriverWait(Driver, new TimeSpan(0, 0, 60));
        public IWebElement CloseModalButton =>
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".cgp-themes-icons-x.cy-modal-x-button")));

        public void CloseModal() => CloseModalButton.Click();
    }
}
