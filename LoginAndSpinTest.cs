using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SparkwareTest.Pages;

namespace SparkwareTest
{
    public class LoginAndSpinTest: DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [TearDown]
        public void GlobalTeardown()
        {
            Driver.Quit();
        }

        [Test]
        public void AuthAndPlayTest()
        {
            Driver.Navigate().GoToUrl("https://www.888casino.ro/");
            Driver.Manage().Window.Maximize();

            var homePage = new HomePage();
            var loginForm = new LoginForm();
            var accountVerificationModal = new AccountVerificationModal();

            homePage.ClickTheLoginButton();
            loginForm.Login("Amazing91009", "Testing1234");
            accountVerificationModal.CloseModal();

        }

        
    }
}