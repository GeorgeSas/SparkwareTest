using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SparkwareTest.Pages
{
    class HomePage : DriverHelper
    {
        public WebDriverWait Wait { get; set; } = new WebDriverWait(Driver, new TimeSpan(0, 0, 60));
        public IWebElement LoginBtn => Driver.FindElement(By.ClassName("sc-fzoydu"));
        public IWebElement SearchInput => Driver.FindElement(By.ClassName("cy-game-search-input"));
        public IList<IWebElement> ListOfGames => Driver.FindElements(By.ClassName("cy-search-game-item"));

        public IWebElement DisplayedUserName => 
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".sc-qYHkt.bUQxfF")));

        public void OpenTheLoginForm() => LoginBtn.Click();

        public void SearchAndAccessGame(string game)
        {
            SearchInput.Click();
            SearchInput.SendKeys(game);

            foreach (var item in ListOfGames)
            {
                if (item.Text.Contains("Trail of Treats")) item.Click();
                else throw new NoSuchElementException();
            }
            
        }
    }
}
