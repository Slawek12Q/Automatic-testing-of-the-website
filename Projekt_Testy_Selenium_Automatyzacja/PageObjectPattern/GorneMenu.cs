using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Projekt_Testy_Selemium_Automatyzacja.BazaTestow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Testy_Selemium_Automatyzacja.PageObjectPattern
{
    class GorneMenu
    {
        [FindsBy(How = How.CssSelector, Using = "#MenuContent a[href*='signonForm']")]
        public IWebElement gorneMenu { get; set; }

        public GorneMenu ()
        {
            PageFactory.InitElements(DriveManager.getDriver(), this);
        }

        public StronaLogowania kliknijWLinkDoLogowania()
        {
            gorneMenu.Click();

            return new StronaLogowania();
        }
    }
}
