using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace atFrameWork2.TestCases
{
    /*
    class Case_RegAUser : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            return new List<TestCase>
            {
                new TestCase("Регистрация пользователя", (driver, homePage) => CreateEvent(driver, homePage))
            };
        }

        public void CreateEvent(IWebDriver driver, PortalHomePage homePage)
        {
            homePage.LeftMenu
                .OpenSection(PortalLeftMenu.Company);

            var btnInviteUser = new WebItem("//button[text()='Пригласить сотрудников']", "Пригласить сотрудников");
            btnInviteUser.Click(driver);

            var sliderFrame = new WebItem("//iframe[@class='side-panel-iframe']", "Фрейм слайдера");
            sliderFrame.SwitchToFrame(driver);

            var btnRegUser = new WebItem("//a[@data-role='menu-add']", "Зарегистрировать");
            btnRegUser.Click(driver);

            var inputNameUser = new WebItem("//input[@id='ADD_NAME']", "Ввод имени");
   
            //inputNameUser.SendKeys(task.Title, driver);
            
            var btnAddEvent = new WebItem("//span[@id='feed-add-post-form-tab-calendar']/child::span", "Кнопка добавить событие");
            btnAddEvent.Click(driver);

            var sliderFrame = new WebItem("//iframe[@class='side-panel-iframe']", "Фрейм слайдера");
            sliderFrame.SwitchToFrame(driver);

            var btnSave = new WebItem("//input[@id='calendar_edit_slider_608142327_save']", "Кнопка сохранить");
            btnSave.Click(driver);

            var btnView = new WebItem("//span[@class='ui-notification-balloon-action']", "Кнопка просмотра созданного события");
            btnView.Click(driver); 
            
}
    }*/
}

