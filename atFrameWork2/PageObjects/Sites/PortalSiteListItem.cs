using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects.SiteSliders
{
    class PortalSiteListItem
    {
        IWebDriver driver;

        public PortalSiteListItem(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static PortalSiteList CreateNewSite =>
            new PortalSiteList("Шаблоны", new WebItem("//a[@href='/sites/site/edit/0/']", "Создание своего шаблона"));

        public void OpenSection(PortalSiteList menuItem)
        {
            menuItem.Select(driver);
        }
    }
}
