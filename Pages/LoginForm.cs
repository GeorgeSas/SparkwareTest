using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SparkwareTest.Pages
{
    class LoginForm: DriverHelper
    {
        public IWebElement UsernameField => Driver.FindElement(By.Id("rlLoginUsername"));
        public IWebElement PasswordField => Driver.FindElement(By.Id("rlLoginPassword"));
        public IWebElement SubmitBtn => Driver.FindElement(By.Id("rlLoginSubmit"));

        public void Login(string username, string password)
        {
            UsernameField.SendKeys(username);
            PasswordField.SendKeys(password);
            SubmitBtn.Click();
        }
    }
}
