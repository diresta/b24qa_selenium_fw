using atFrameWork2.PageObjects.LeftMenu;
using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    class PortalLeftMenu
    {
        IWebDriver driver;

        public PortalLeftMenu(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static PortalLeftMenuItem Tasks =>
            new PortalLeftMenuItem("Задачи", new WebItem("//li[@id='bx_left_menu_menu_tasks']", "Пункт левого меню 'Задачи'"));
        public static PortalLeftMenuItem Sites =>
            new PortalLeftMenuItem("Сайты", new WebItem("//li[@id='bx_left_menu_menu_sites']", "Пункт левого меню 'Сайты'"));
        public static PortalLeftMenuItem Company =>
            new PortalLeftMenuItem("Сотрудники", new WebItem("//li[@id='bx_left_menu_menu_company']", "Пункт левого меню 'Сотрудники'"));
        public static PortalLeftMenuItem Disk =>
           new PortalLeftMenuItem("Диск", new WebItem("//li[@id='bx_left_menu_menu_files']", "Пункт левого меню 'Диск'"));

        public void OpenSection(PortalLeftMenuItem menuItem)
        {
            menuItem.Select(driver);
        }
    }
}
