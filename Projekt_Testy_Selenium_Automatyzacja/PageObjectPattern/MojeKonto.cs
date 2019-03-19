using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Projekt_Testy_Selemium_Automatyzacja.BazaTestow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Testy_Selemium_Automatyzacja.PageObjectPattern
{
    class MojeKonto
    {
        [FindsBy(How = How.CssSelector, Using = "div#Catalog > form > table > tbody > tr > td:nth-of-type(2)")]
        public IWebElement uzytkownik { get; set; }

        [FindsBy(How = How.Name, Using = "account.firstName")]
        public IWebElement imie { get; set; }

        [FindsBy(How = How.Name, Using = "account.lastName")]
        public IWebElement nazwisko { get; set; }

        [FindsBy(How = How.Name, Using = "account.languagePreference")]
        public IWebElement preferencjeJezykowe { get; set; }

        [FindsBy(How = How.Name, Using = "account.listOption")]
        public IWebElement myList { get; set; }

        [FindsBy(How = How.Name, Using = "account.bannerOption")]
        public IWebElement myBanner { get; set; }

        [FindsBy(How = How.Name, Using = "editAccount")]
        public IWebElement zapiszInformacje { get; set; }

        public MojeKonto ()
        {
            PageFactory.InitElements(DriveManager.getDriver(), this);
        }

        public MojeKonto zmienImie(String noweImie)
        {
            imie.Clear();
            imie.SendKeys(noweImie);
            return this;
        }

        public MojeKonto zmienNazwisko (String noweNazwisko)
        {
            nazwisko.Clear();
            nazwisko.SendKeys(noweNazwisko);
            return this;
        }

        public MojeKonto zatwierdzDane ()
        {
            zapiszInformacje.Click();

            return this;
        }

        public String pobierzImie()
        {
            return imie.GetAttribute("value");
        }

        public String pobierzNazwisko ()
        {
            return nazwisko.GetAttribute("value");
        }

        public String pobierzUzytkownika()
        {
            return uzytkownik.Text;
        }

        public Boolean czyMojaLista ()
        {
            return myList.Selected;
        }

        public Boolean czyMojBanner()
        {
            return myBanner.Selected;
        }

        public MojeKonto kiknijWMyList()
        {
            myList.Click();

            return this;
        }

        public MojeKonto kliknijMyBanner()
        {
            myBanner.Click();

            return this;
        }

        public String zwrocJezyk()
        {
            var wybranyElement = new SelectElement(preferencjeJezykowe);
            return wybranyElement.SelectedOption.Text;
        }

        public MojeKonto zmienjezyk(String jezyk)
        {
            var wybranyElement = new SelectElement(preferencjeJezykowe);
            wybranyElement.SelectByValue(jezyk);

            return this;
        }

    }
}
