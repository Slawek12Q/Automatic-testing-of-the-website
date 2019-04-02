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
    class StronaStopki
    {
        [FindsBy(How = How.CssSelector, Using = "#Banner img[src*='dog']")]
        public IWebElement stronaStopki { get; set; }

        public StronaStopki ()
        {
            PageFactory.InitElements(DriveManager.getDriver(), this);
        }

        public Boolean czyBanerJestWyswietlony()
        {
            Boolean czyWyswietlony = stronaStopki.Displayed;
            return czyWyswietlony;
        }
    }
}
