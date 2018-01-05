using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Framework.Pages
{
    class InformationPage
    {

        private const string BaseUrl = "https://www.aeroflot.ru/ru-ru/information";

        [FindsBy(How = How.CssSelector, Using = "#main-container > div > div > div > div:nth-child(1) > ul > li:nth-child(5) > a")]
        private IWebElement selectElBort;

        [FindsBy(How = How.CssSelector, Using = "#main-container > div > div > div.node > div:nth-child(1) > ul > li:nth-child(1) > a")]
        private IWebElement selectShema;
        
        [FindsBy(How = How.CssSelector, Using = "#Guide_mainDiv > div > div:nth-child(3) > div:nth-child(2) > a")]
        private IWebElement selectAero;

        private IWebDriver driver;
        public InformationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public void Test8()
        {
            selectElBort.Click();
            selectShema.Click();
            selectAero.Click();
        }




    }
}
