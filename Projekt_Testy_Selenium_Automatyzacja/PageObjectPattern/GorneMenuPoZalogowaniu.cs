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
    class GorneMenuPoZalogowaniu
    {
        [FindsBy(How = How.CssSelector, Using = "div#MenuContent > a:nth-of-type(3)")]
        public IWebElement mojeKonto { get; set; }
        

        public GorneMenuPoZalogowaniu()
        {
            PageFactory.InitElements(DriveManager.getDriver(), this);
        }

        public MojeKonto przejdzDoMojegoKonta()
        {
            mojeKonto.Click();
            return new MojeKonto();
        }

    }
}
