using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using Projekt_Testy_Selemium_Automatyzacja.BazaTestow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Testy_Selemium_Automatyzacja.PageObjectPattern
{
    class StronaPoczatkowa
    {
        [FindsBy(How = How.CssSelector, Using = "#Content a")]
        public IWebElement stronaPoczatkowa { get; set; }

        public StronaPoczatkowa()
        {
            PageFactory.InitElements(DriveManager.getDriver(), this);
        }

        public GorneMenu kliknijIWejdzNaStrone ()
        {
            stronaPoczatkowa.Click();

            return new GorneMenu();
        }


    }
}
