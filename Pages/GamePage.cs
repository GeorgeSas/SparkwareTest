using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SparkwareTest.Pages
{
    class GamePage: DriverHelper
    {
        public IWebElement SpinButton => Driver.FindElement(By.Id("spin_button"));

        public void SpinOneTime()
        {
            SpinButton.Click();
        }
    }
}
