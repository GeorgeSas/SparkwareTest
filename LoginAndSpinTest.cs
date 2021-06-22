using System;
using System.Configuration;
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
            Driver.Navigate().GoToUrl(TestData.APP_URL);
            Driver.Manage().Window.Maximize();

            var homePage = new HomePage();
            var loginForm = new LoginForm();
            var accountVerificationModal = new AccountVerificationModal();
            var gamePage = new GamePage();

            homePage.OpenTheLoginForm();

            loginForm.Login(TestData.VALID_USERNAME, TestData.VALID_PASSWORD);
            Assert.AreEqual(homePage.DisplayedUserName.Text, TestData.VALID_USERNAME.ToUpper());

            accountVerificationModal.CloseModal();

            homePage.SearchAndAccessGame("Trail of Treats");

            ///gamePage.SpinOneTime();
        }

        
    }
}