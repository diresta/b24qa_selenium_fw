using atFrameWork2.PageObjects.SiteSliders;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    class PortalHomePage
    {
        IWebDriver driver;
        public PortalLeftMenu LeftMenu => new PortalLeftMenu(driver);

        public PortalSiteListItem SitesList => new PortalSiteListItem(driver);

        public PortalHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
