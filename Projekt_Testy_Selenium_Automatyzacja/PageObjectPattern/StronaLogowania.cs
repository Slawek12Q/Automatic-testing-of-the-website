using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using Projekt_Testy_Selemium_Automatyzacja.BazaTestow;

namespace Projekt_Testy_Selemium_Automatyzacja.PageObjectPattern
{
    class StronaLogowania
    {
       [FindsBy(How = How.Name, Using = "username")]
       public IWebElement poleDoImienia { get; set; }

       [FindsBy(How=How.Name, Using = "password")]
       public IWebElement poleDoHasla { get; set; }

       [FindsBy(How=How.Name, Using = "signon")]
       public IWebElement przyciskLogowania { get; set; }

       [FindsBy(How=How.CssSelector, Using = "#Content ul[class='messages'] li")]
       public IWebElement wiadomoscPoZalogowaniu { get; set; }


        public StronaLogowania()
        {
            PageFactory.InitElements(DriveManager.getDriver(), this);
        }

        public StronaLogowania wprowadzLogin (string login)
        {
            poleDoImienia.Clear();
            poleDoImienia.SendKeys(login);

            return this;
        }

        public StronaLogowania wprowadzHaslo (string haslo)
        {
            poleDoHasla.Clear();
            poleDoHasla.SendKeys(haslo);

            return this;
        }

        public StronaStopki kliknijWPrzyciskLogowania()
        {
            przyciskLogowania.Click();

            return new StronaStopki();
        }

        public String pobierzWiadomosc()
        {
            return wiadomoscPoZalogowaniu.Text;
        }

        public String pobierzZawartoscPolaLogowania()
        {
            return poleDoImienia.Text;
        }




    }
}
