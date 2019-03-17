using NUnit.Framework;
using OpenQA.Selenium;
using Projekt_Testy_Selemium_Automatyzacja.BazaTestow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//kazdy nasz test wykonuje te operacje wiec wydzielilismy je do osobnej klasy i kazda klasa trstowa po niej dziedziczy 
//krotko mowiac to co jest tutaj wykonuje sie w kazdej klasie testowej
// setup - to przygotowanie do testu a teradown to operacje po tescie

namespace Projekt_Testy_Selemium_Automatyzacja
{   [TestFixture]
    class BazaTestowa
    {
        protected IWebDriver driver;
        

        [SetUp]
        public void przedTestem()
        {
            driver = DriveManager.getDriver();
            var adressUrl = "http://przyklady.javastart.pl/jpetstore/";
            driver.Navigate().GoToUrl(adressUrl);
            driver.Manage().Window.Maximize();
         }


        [TearDown]
        public void poTescie()
        {
            DriveManager.wylaczDrivera();
        }
    }

   
}
