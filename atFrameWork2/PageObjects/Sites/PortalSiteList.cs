using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects.SiteSliders
{
    class PortalSiteList
    {
        WebItem menuItem;

        public PortalSiteList(string title, WebItem menuItem)
        {
            Title = title;
            this.menuItem = menuItem;
        }

        public string Title { get; }

        public void Select(IWebDriver driver)
        {
            menuItem.Click(driver);
        }
    }
}

