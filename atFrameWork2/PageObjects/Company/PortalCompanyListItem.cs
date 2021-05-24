using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    class PortalCompanyListItem
    {
        IWebDriver driver;

        public PortalCompanyListItem(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static PortalCompanyList InviteUsers =>
            new PortalCompanyList("Пригласить сотрудников", new WebItem("//button[text()='Пригласить сотрудников']", "Пригласить сотрудников"));
        public static PortalCompanyList RegNewUser =>
            new PortalCompanyList("Пригласить сотрудников", new WebItem("//a[@data-role='menu-add']", "Пригласить сотрудников"));
        public static PortalCompanyList AddUser =>
            new PortalCompanyList("Добавить пользователя", new WebItem("//button[@id='intranet-invitation-btn']", "Добавить пользователя"));
        public static PortalCompanyList SliderIframe =>
            new PortalCompanyList("Айфрейм слайдера", new WebItem("//iframe[@class='side-panel-iframe']", "Айфрейм слайдера"));

        public void OpenSection(PortalCompanyList menuItem)
        {
            menuItem.Select(driver);
        }

        public void Switch(PortalCompanyList menuItem)
        {
            menuItem.Switch(driver);
        }

    }
}
