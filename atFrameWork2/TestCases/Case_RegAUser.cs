using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using atFrameWork2.PageObjects.SiteSliders;
using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace atFrameWork2.TestCases
{
    class Case_RegAUser : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            return new List<TestCase>
            {
                new TestCase("Регистрация пользователя", (driver, homePage) => CreateEvent(driver, homePage))
            };
        }

        public void CreateEvent(IWebDriver driver, PortalHomePage homePage)
        {
            Random rnd = new Random();
            var nameSalt = rnd.Next(10000);

            homePage.LeftMenu.OpenSection(PortalLeftMenu.Company);
            homePage.CompanyList.OpenSection(PortalCompanyListItem.InviteUsers);
            homePage.CompanyList.Switch(PortalCompanyListItem.SliderIframe);
            homePage.CompanyList.OpenSection(PortalCompanyListItem.RegNewUser);
            
            var inputNameUser = new WebItem("//input[@id='ADD_NAME']", "Ввод имени");
            inputNameUser.SendKeys("testName" + nameSalt, driver);
            
            var inputLastnameUser = new WebItem("//input[@id='ADD_LAST_NAME']", "Ввод Фамилии");
            inputLastnameUser.SendKeys("testLastname" + nameSalt, driver);

            var inputEmailUser = new WebItem("//input[@id='ADD_EMAIL']", "Ввод email");
            inputEmailUser.SendKeys("testemail@"+ nameSalt + "kamabullet.ru", driver);

            homePage.CompanyList.OpenSection(PortalCompanyListItem.AddUser);
        }
    }
        }

