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
    [TestFixture]
    class DokonajPelnegoZakupu : PrzejscieDoZalogowanegoKonta
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
            //wroc do menu glownego
            driver.FindElement(By.CssSelector("div#BackLink > a")).Click();
            //wybierzmy koty
            driver.FindElement(By.CssSelector("div#SidebarContent > a:nth-of-type(3) > img")).Click();
            //wybierzmy koty persy
            driver.FindElement(By.CssSelector("div#Catalog > table > tbody > tr:nth-of-type(3) > td > a")).Click();
            //wybieramy kota samice i dodajemy do koszyka
            driver.FindElement(By.CssSelector("div#Catalog > table > tbody > tr:nth-of-type(2) > td:nth-of-type(5) > a")).Click();
            //idziemy do koszyka
            driver.FindElement(By.CssSelector("div#MenuContent > a > img")).Click();
            //potwierdzamy ze chcemy kupic to co mamy w koszyku
            driver.FindElement(By.CssSelector("div#Cart > a")).Click();
            //zatwierdzamy dane i idziemy dalej
            driver.FindElement(By.CssSelector("div#Catalog > form > input")).Click();
            //zatwierdzamy nasz zakup
            driver.FindElement(By.CssSelector("div#Catalog > a")).Click();

            var koniec = driver.FindElement(By.CssSelector("div#Content > ul > li"));

            String message = koniec.Text;

            Assert.AreEqual("Thank you, your order has been submitted.", message);
        }
    }
}
