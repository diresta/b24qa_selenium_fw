using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using atFrameWork2.PageObjects.SiteSliders;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace atFrameWork2.TestCases
{
    class Case_Sites : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            return new List<TestCase>
            {
                new TestCase("Создание сайта", (driver, homePage) => CreateSite(driver, homePage)),
            };
        }

        public static void CreateSite(IWebDriver driver, PortalHomePage homePage)
        {
            homePage.LeftMenu.OpenSection(PortalLeftMenu.Sites);//Кнопка сайта левого меню
            homePage.SitesList.OpenSection(PortalSiteListItem.CreateNewSite);//Кнопка создания нового сайта
            //var leftMenuSitesButton = new WebItem("//a[@href='/sites/site/edit/0/']", "Кнопка создания нового сайта");
            //leftMenuSitesButton.Click(driver);
            var sitePanelFrame = new WebItem("//iframe[@class='side-panel-iframe']", "Фрейм слайдера с шаблонами сайтов");
            sitePanelFrame.SwitchToFrame(driver);
            var emptyTemplate = new WebItem("//span[@id='landing-demo-empty']//span[@class='landing-item-inner']", "Пустой шаблон");
            emptyTemplate.Click(driver);
            driver.SwitchTo().DefaultContent();
            var createTemplateFrame = new WebItem("//div[@class='side-panel side-panel-container']//div[@class='side-panel-content-container']//iframe", "Фрейм дескрипшона шаблона");
            createTemplateFrame.SwitchToFrame(driver);
            //var inputTemplateTitle = new WebItem("//input[@data-name='title']", "Тайтл шаблона");
            //var templateTitleButton = new WebItem("//div[@class='pagetitle landing-template-preview-title']//span[@class='landing-template-preview-edit-btn ui-title-input-btn-js']", "Кнопка редактирования шаблона");
            //templateTitleButton.Click(driver);
            //var site = new Bitrix24Sites("testSites" + DateTime.Now.Ticks) { Description = "Какой то дескрипшн" + +DateTime.Now.Ticks };
            //inputTemplateTitle.SendKeys(site.Title, driver);
            //var templateDescriptionButton = new WebItem("//p[@id='landing-template-preview-description-text']//span[@class='landing-template-preview-edit-btn ui-title-input-btn-js']", "Кнопка редактирования описания");
            //var inputTemplateDescription = new WebItem("//textarea[@data-name='description']", "Дескрипшн шаблона");
            //templateDescriptionButton.Click(driver);
            //inputTemplateDescription.SendKeys(site.Title, driver);
            //var redColor = new WebItem("//div[@data-metrika24value='f74c3c']", "Красный цвет");
            //redColor.Click(driver);
            var createButton = new WebItem("//a[@class='ui-btn ui-btn-success landing-template-preview-create']", "Кнопка 'Создать'");
            createButton.Click(driver);
            var landingPublicationButton = new WebItem("//a[@id='landing-publication']", "Кнопка 'Опубликовать'");
            landingPublicationButton.Click(driver);
        }
    }
}

