using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Projekt_Testy_Selemium_Automatyzacja.BazaTestow;
using Projekt_Testy_Selemium_Automatyzacja.PageObjectPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//klasa testowan ma moje potrzeby testuje przyrost kodu, nie jest to zwiazane z projektem 

namespace Projekt_Testy_Selemium_Automatyzacja.Testy
{
    [TestFixture]
    class Test : PrzejscieDoZalogowanegoKonta
    {
        [Test]
       public void test()
        {
            StronaStopki stopki = new StronaStopki();
            Boolean wiadomosc = stopki.czyBanerJestWyswietlony();

            Assert.IsTrue(wiadomosc);
          
        }
    }
}
