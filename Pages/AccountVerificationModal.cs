using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SparkwareTest.Pages
{
    class AccountVerificationModal: DriverHelper
    {
        public IWebElement CloseModalBtn => Driver.FindElement(By.ClassName("cy-modal-x-button"));

        public void CloseModal() => CloseModalBtn.Click();
    }
}
