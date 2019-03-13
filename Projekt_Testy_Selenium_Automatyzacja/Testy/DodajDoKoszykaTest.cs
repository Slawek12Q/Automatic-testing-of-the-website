using NUnit.Framework;
using OpenQA.Selenium;
using Projekt_Testy_Selemium_Automatyzacja.BazaTestow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Testy_Selemium_Automatyzacja.Testy
{
    //kupujemy rybke koi i sprawdzamy czy jest w koszyku

    [TestFixture]
    class DodajDoKoszykaTest : PrzejscieDoZalogowanegoKonta
    {
        [Test]
        public void test()
        {
            //znajdz rybki na stronie glownej i kliknij
            driver.FindElement(By.CssSelector("div#SidebarContent > a > img")).Click();
            //znajdzy gatunek koi i kliknij
            driver.FindElement(By.CssSelector("div#Catalog > table > tbody > tr:nth-of-type(4) > td > a")).Click();
            //wybierz pierwsza dostepna opcje i kliknij
            driver.FindElement(By.CssSelector("div#Catalog > table > tbody > tr:nth-of-type(2) > td:nth-of-type(5) > a")).Click();
            //kliknij w koszy 
            driver.FindElement(By.CssSelector("div#MenuContent > a > img")).Click();
            var zawartosc = driver.FindElement(By.CssSelector("div#Cart > form > table > tbody > tr:nth-of-type(2) > td:nth-of-type(3)"));
            String wiadomosc = zawartosc.Text;

            Assert.AreEqual("Spotted Koi", wiadomosc);
        }
    }
}
