using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace Framework.Pages
{
    public class MainPage
    {
        
        private const string BaseUrl = "https://www.aeroflot.ru/ru-ru";
        /// <summary>
        /// Переключение страницы на немецкий язык
        /// </summary>
        #region
        [FindsBy(How = How.CssSelector, Using = "#header-menu > div.language-selector2.menu-btn > div")]
        private IWebElement buttonLanguage;

        [FindsBy(How = How.CssSelector, Using = "li.selected:nth-child(4)")]
        private IWebElement selectCountry;

        [FindsBy(How = How.CssSelector, Using = "#lang > ul:nth-child(1) > li:nth-child(3)")]
        private IWebElement selectLanguage;

        [FindsBy(How = How.CssSelector, Using = "#set_lang_locale")]
        private IWebElement buttonSelest;
        #endregion
        /// <summary>
        /// поиск рейса по заданным параметрам
        /// </summary>
        #region
        [FindsBy(How = How.CssSelector, Using = "#ttOri0")]
        private IWebElement inputCountryOfDispatch;

        [FindsBy(How = How.CssSelector, Using = "#ttDest0")]
        private IWebElement inputCountryOfArrival;

        [FindsBy(How = How.CssSelector, Using = "#ttLeaveDate0")]
        private IWebElement inputDateDepature;

        [FindsBy(How = How.CssSelector, Using = "#ttSubmitBtn")]
        private IWebElement BottonSearch;


        #endregion
        /// <summary>
        /// Поиск отеля
        /// </summary>
        #region
        [FindsBy(How = How.CssSelector, Using = "#hotelTab > span")]
        private IWebElement buttonHotel;

        [FindsBy(How = How.CssSelector, Using = "#cityInput")]
        private IWebElement inputCityHotel;

        [FindsBy(How = How.CssSelector, Using = "#dateFromInput")]
        private IWebElement inputDateFrom;
        [FindsBy(How = How.CssSelector, Using = "#dateToInput")]
        private IWebElement inputDateInput;

        [FindsBy(How = How.CssSelector, Using = "#HotelbookSearchForm > form > a")]
        private IWebElement BottonSearchHotel;

        #endregion

        /// <summary>
        /// Аренда автомобиля
        /// </summary>
        #region
        [FindsBy(How = How.CssSelector, Using = "##europcarTab > span")]
        private IWebElement buttonAuto;

        [FindsBy(How = How.CssSelector, Using = "#euCountryBox > div > div > a")]
        private IWebElement inputCountry;

        [FindsBy(How = How.CssSelector, Using = "#euDestBox > div.ffSelectWrapper.active > div > a")]
        private IWebElement inputPlase;
        [FindsBy(How = How.CssSelector, Using = "#euPickUpDate")]
        private IWebElement inputDateFromT;
        [FindsBy(How = How.CssSelector, Using = "#euDropOffDate")]
        private IWebElement inputDateInputT;
        [FindsBy(How = How.CssSelector, Using = "# euCountryOfResidenceBox > div > div > a")]
        private IWebElement inputCountryN;


        [FindsBy(How = How.CssSelector, Using = "#euSubmitBtn")]
        private IWebElement ButtonSearchAuto;

        #endregion
        private IWebDriver driver;
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);

        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public void Test1()
        {
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", buttonLanguage);

            IJavaScriptExecutor ex1 = (IJavaScriptExecutor)driver;
            ex1.ExecuteScript("arguments[0].click();", selectCountry);

            IJavaScriptExecutor ex2 = (IJavaScriptExecutor)driver;
            ex2.ExecuteScript("arguments[0].click();", selectLanguage);

            IJavaScriptExecutor ex3 = (IJavaScriptExecutor)driver;
            ex3.ExecuteScript("arguments[0].click();", buttonSelest);
           // buttonLanguage.Click();
           //selectCountry.Click();
           //selectLanguage.Click();
           //buttonSelest.Click();


        }
        public void Test2(string A, string B,string date)
        {

            inputCountryOfDispatch.SendKeys(A);
            inputCountryOfDispatch.SendKeys(B);
            inputDateDepature.SendKeys(date);
            BottonSearch.Click();
        }
        public void Test3(string Country, string datefrom, string dateinput)
        {
            inputCityHotel.SendKeys(Country);
            inputDateFrom.SendKeys(datefrom);
            inputDateInput.SendKeys(dateinput);
            buttonHotel.Click();


        }

        public void Test4(string Country, string place, string date1, string date2, string countryN)
        {
            buttonAuto.Click();
            inputCountry.SendKeys(Country);
            inputPlase.SendKeys(place);
            inputDateFromT.SendKeys(date1);
            inputDateInputT.SendKeys(date2);
            inputCountryN.SendKeys(countryN);
            ButtonSearchAuto.Click();


        }

    }

}
