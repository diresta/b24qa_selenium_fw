using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.PageObjects
{
    class PortalDiskListItem
    {
        IWebDriver driver;

        public PortalDiskListItem(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static PortalDiskList AddFolder =>
            new PortalDiskList("Кнопка добавить", new WebItem("//button[@class='ui-btn js-disk-add-button ui-btn-primary ui-btn-dropdown']", "Кнопка добавить"));
        public static PortalDiskList MakeAFolderBtn =>
            new PortalDiskList("Кнопка папку", new WebItem("//div[@class='menu-popup']//span[text()='Папка']", "Кнопка папку"));
        public static PortalDiskList FolderName =>
            new PortalDiskList("Имя папки", new WebItem("//input[@id='disk-new-create-filename']", "Имя папки"));

       // var FolderName = new Bitrix24Folder("testFolder" + DateTime.Now.Ticks);
      // inputFolderName.SendKeys(FolderName.Title, driver);

        public static PortalDiskList CreateBtn =>
            new PortalDiskList("Кнопка создать", new WebItem("//span[@class='ui-btn ui-btn-success']", "Кнопка создать"));

        public void OpenSection(PortalDiskList menuItem)
        {
            menuItem.Select(driver);
        }

        public void Switch(PortalDiskList menuItem)
        {
            menuItem.Switch(driver);
        }

    }
}
