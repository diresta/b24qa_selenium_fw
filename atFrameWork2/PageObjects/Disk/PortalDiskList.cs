using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    class PortalDiskList
    {
        WebItem menuItem;
        
    public PortalDiskList(string title, WebItem menuItem)
        {
           Title = title;
           this.menuItem = menuItem;
        }

    public string Title { get; }

    public void Select(IWebDriver driver)
        {
            menuItem.Click(driver);
        }

    public void Switch(IWebDriver driver)
        {
           menuItem.SwitchToFrame(driver);
        }
    }
}
