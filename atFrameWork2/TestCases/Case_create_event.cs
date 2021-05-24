using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace atFrameWork2.TestCases
{
    class Case_create_event : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            return new List<TestCase>
            {
                new TestCase("Создание события", (driver, homePage) => CreateEvent(driver, homePage))
            };
        }

        private string loginURL = "https://auth2.bitrix24.net/oauth/authorize/";
        private string login = "testing.mail.bitrix@mail.ru";
        private string password = "bitrix24";

        public void CreateEvent(IWebDriver driver, PortalHomePage homePage)
        {
            driver.Navigate().GoToUrl(loginURL);

            var loginField = new WebItem("//input[@id='login']", "Поле для ввода логина");
            var pwdField = new WebItem("//input[@id='password']", "Поле для ввода пароля");

            loginField.SendKeys(login, driver);
            Thread.Sleep(1000);
            
            loginField.SendKeys(Keys.Enter, driver);
            pwdField.SendKeys(password + Keys.Enter, driver);
            Thread.Sleep(1000);
            
            pwdField.SendKeys(Keys.Enter, driver);

            var btnAddEvent = new WebItem("//span[@id='feed-add-post-form-tab-calendar']/child::span", "Кнопка добавить событие");
            btnAddEvent.Click(driver);

            var sliderFrame = new WebItem("//iframe[@class='side-panel-iframe']", "Фрейм слайдера");
            sliderFrame.SwitchToFrame(driver);

            var btnSave = new WebItem("//input[@id='calendar_edit_slider_608142327_save']", "Кнопка сохранить");
            btnSave.Click(driver);

            var btnView = new WebItem("//span[@class='ui-notification-balloon-action']", "Кнопка просмотра созданного события");
            btnView.Click(driver);
        }
    }
}