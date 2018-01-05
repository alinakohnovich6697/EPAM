using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Framework.Pages
{
    class SpecialOffersPage
    {
        const string BaseUrl = "https://www.aeroflot.ru/ru-ru/special_offers";
        [FindsBy(How = How.CssSelector, Using = "#main-container > div > div > div > div:nth-child(1) > ul > li:nth-child(2) > a")]
        private IWebElement buttonNewDirection;
        [FindsBy(How = How.XPath, Using = "#main-container > div > div > div.node > div:nth-child(1) > ul > li:nth-child(1) > a")]
        private IWebElement buttonPlase;


        private IWebDriver driver;
        public SpecialOffersPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public void Test5()
        {
            buttonNewDirection.Click();
            buttonPlase.Click();
            
        }
    }
}
