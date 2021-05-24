using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.TestCases
{
    class Case_DiskFolderCreate : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            return new List<TestCase>
            {
                new TestCase("Создание папки на диске", (driver, homePage) => CreateEvent(driver, homePage))
            };
        }
        public void CreateEvent(IWebDriver driver, PortalHomePage homePage)
        {
            homePage.LeftMenu
                .OpenSection(PortalLeftMenu.Disk);

            var btnAdd = new WebItem("//button[@class='ui-btn js-disk-add-button ui-btn-primary ui-btn-dropdown']", "Кнопка добавить");
                btnAdd.Click(driver);

            var btnFolder = new WebItem("//div[@class='menu-popup']//span[text()='Папка']", "Кнопка папку");
            btnFolder.Click(driver);

            var inputFolderName = new WebItem("//input[@id='disk-new-create-filename']", "Имя папки");
            var FolderName = new Bitrix24Folder("testFolder" + DateTime.Now.Ticks);
            inputFolderName.SendKeys(FolderName.Title, driver);

            var btnFolderCreate = new WebItem("//span[@class='ui-btn ui-btn-success']", "Кнопка создать");
            btnFolderCreate.Click(driver);
        }
    }
}
