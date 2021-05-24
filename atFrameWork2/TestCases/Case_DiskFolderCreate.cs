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
            homePage.LeftMenu.OpenSection(PortalLeftMenu.Disk);
            homePage.DiskList.OpenSection(PortalDiskListItem.AddFolder);
            homePage.DiskList.OpenSection(PortalDiskListItem.MakeAFolderBtn);

            var inputFolderName = new WebItem("//input[@id='disk-new-create-filename']", "Имя папки");
            var FolderName = new Bitrix24Folder("testFolder" + DateTime.Now.Ticks);
            inputFolderName.SendKeys(FolderName.Title, driver);

            homePage.DiskList.OpenSection(PortalDiskListItem.CreateBtn);
           
        }
    }
}
