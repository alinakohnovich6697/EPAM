using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework;
using Framework.Driver;
using Framework.Pages;
namespace Framework
{
    [TestClass]
    public class UnitTest1
    {
        private const string reverse_ticket_error_message = "Бронирование с указанными данными не найдено.";
        //private const string online_servise_error_message = "По заданному номеру авианакладной ничего не найдено"

        //1
        [TestMethod]
        public void LangusgeRu_Deu()
        {
            var driver = DriverInstance.GetInstance();
            MainPage mainPage = new MainPage(driver);
            mainPage.OpenPage();

            mainPage.Test1();
        }

        //2
        [TestMethod]
        public void Aeroport()
        {
                var driver = DriverInstance.GetInstance();
               MainPage mainPage = new MainPage(driver);
                mainPage.OpenPage();

                mainPage.Test2("Минск, Minsk (MHP, MSQ), Беларусь, Belarus", "Манчестер, Manchester (MAN), Великобритания, United Kingdom", "28.01.2018");
        }
        //3
        [TestMethod]
        public void Hotel()
        {
            var driver = DriverInstance.GetInstance();
            MainPage mainPage = new MainPage(driver);
            mainPage.OpenPage();

            mainPage.Test3( "Манчестер, Manchester (MAN), Великобритания, United Kingdom", "28.01.2018", "30.01.18");
        }
        //4
        [TestMethod]
        public void Auto()
        {
            var driver = DriverInstance.GetInstance();
            MainPage mainPage = new MainPage(driver);
            mainPage.OpenPage();

            mainPage.Test4("Соединенное королевство", "manchester trafford park", "28.01.2018", "30.01.18","Беларусь");
        }
        //5
        [TestMethod]
        public void NewAero()
        {
            var driver = DriverInstance.GetInstance();
            SpecialOffersPage specialOffersPage = new SpecialOffersPage(driver);
            specialOffersPage.OpenPage();

            specialOffersPage.Test5();


        }
        //6
        [TestMethod]
        public void ReverseTicket()
        {
            var driver = DriverInstance.GetInstance();
            OnlinePage onlinePage = new OnlinePage(driver);
            onlinePage.OpenPage();

            onlinePage.Test6("0786542", "Kohnovich");

            Assert.IsTrue(onlinePage.GetErrorPassengers(reverse_ticket_error_message));
        }
        //7
        [TestMethod]
        public void Status()
        {
            var driver = DriverInstance.GetInstance();
            OnlinePage onlinePage = new OnlinePage(driver);
            onlinePage.OpenPage();

            onlinePage.Test7("234234");

        }
        //8
        [TestMethod]
        public void InformationPlase()
        {
            var driver = DriverInstance.GetInstance();
            InformationPage informationPage = new InformationPage(driver);
            informationPage.OpenPage();

            informationPage.Test8();
        }
    }
}