using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projekt_Testy_Selemium_Automatyzacja
{
    [TestFixture]
    class WejscieNaStroneTest
    {
        [Test]
        public void WejdzNaStroneISprawdzUrl ()
        {
            var driver = new ChromeDriver();
            var adressUrl = "http://przyklady.javastart.pl/jpetstore/";
            driver.Navigate().GoToUrl(adressUrl);
            driver.Manage().Window.Maximize();
            //wchodzimy na stronę przekazaną w zmiennej addressURL, i potem sprawdzamy za pomacą naszego drivera czy faktycznie 
            //jestemy tam gdzie chcielismy
            Assert.AreEqual(adressUrl, driver.Url);

            driver.Close();

        }
    }
}
