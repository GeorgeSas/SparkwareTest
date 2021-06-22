using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SparkwareTest.Pages
{
    class HomePage : DriverHelper
    {
        public IWebElement LoginBtn => Driver.FindElement(By.ClassName("sc-fzoydu"));

        public void ClickTheLoginButton() => LoginBtn.Click();
    }
}
