using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Testy_Selemium_Automatyzacja.Testy
{
    [TestFixture]
    class WejdzNaStroneISprawdzTytulTest
    {

        [Test]
        public void WejdzNaStroneISprawdzUrl()
        {
            var driver = new ChromeDriver();
            var adressUrl = "http://przyklady.javastart.pl/jpetstore/";
            driver.Navigate().GoToUrl(adressUrl);
            driver.Manage().Window.Maximize();
            //wchodzimy na stronę przekazaną w zmiennej i pobieramy jej tytuł, następnie sprawdzamy czy się zgadza
            var tytul = driver.Title;
            Assert.AreEqual(tytul, "JPetStore Demo");

            driver.Close();

        }
    }
}
