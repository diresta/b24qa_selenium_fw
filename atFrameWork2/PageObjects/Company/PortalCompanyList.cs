using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    class PortalCompanyList
    {

        IWebDriver driver;

        public PortalCompanyList(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static PortalCompanyListItem InviteNewUser =>
            new PortalCompanyListItem("Пригласить сотрудников", new WebItem("//button[text()='Пригласить сотрудников']", "Пригласить сотрудников"));

        public void OpenSection(PortalCompanyListItem menuItem)
        {
            menuItem.Select(driver);
        }

     
    }
}
