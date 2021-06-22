using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SparkwareTest.Pages
{
    class GamePage: DriverHelper
    {
        public IWebElement OKButton => Driver.FindElement(By.Id("cy-play-real-game-button"));
        public IWebElement SpinButton => Driver.FindElement(By.Id("spin_button"));

        private void ConfirmGameFrame()
        {
            OKButton.Click();
        }
        public void SpinOneTime()
        {
            ConfirmGameFrame();
            SpinButton.Click();
        }
    }
}
