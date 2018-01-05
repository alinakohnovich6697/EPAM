using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Framework.Pages
{
    class OnlinePage
    {
        private const string BaseUrl = "https://www.aeroflot.ru/ru-ru/online_services";

        [FindsBy(How = How.CssSelector, Using = "#main-container > div > div > div > div:nth-child(1) > ul > li:nth-child(11) > a")]
        private IWebElement buttonContainer;
        
        [FindsBy(How = How.CssSelector, Using = "#id_awb_1")]
        private IWebElement inputNumbCont;

        [FindsBy(How = How.CssSelector, Using = "#id_cargotrackingform > div > input")]
        private IWebElement buttonSearch;

        //6
        [FindsBy(How = How.CssSelector, Using = "#main-container > div > div > div > div:nth-child(1) > ul > li:nth-child(2) > a")]
        private IWebElement buttonReversTicket;

        [FindsBy(How = How.CssSelector, Using = "#bookingretrieval-reservationCode")]
        private IWebElement inputCode;

        [FindsBy(How = How.CssSelector, Using = "#bookingretrieval-lastName")]
        private IWebElement inputLastName;

        [FindsBy(How = How.CssSelector, Using = "#yui_3_1_2_2_1515095404425554")]
        private IWebElement buttonSearchTwo;

        private IWebDriver driver;

        public OnlinePage(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public void Test6(string code, string lname)
        {
            
             buttonReversTicket.Click();
             inputCode.SendKeys(code);
             inputLastName.SendKeys(lname);
             buttonSearchTwo.Submit();

            }

        public void Test7(string a)
        {
                buttonContainer.Click();
                inputNumbCont.SendKeys(a);
                buttonSearch.Click();

            }

        public bool GetErrorPassengers(string error)
        {
            try
            {
                var errorOnline = driver.FindElement(By.XPath("//*[@id='flow - message - bookingNotFound']/div[1]"));
                return errorOnline.Text.Contains(error);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }






    }
}
