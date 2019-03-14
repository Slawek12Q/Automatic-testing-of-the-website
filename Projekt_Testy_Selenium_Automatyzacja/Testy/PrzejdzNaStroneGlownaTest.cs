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
    class PrzejdzNaStroneGlownaTest 
    {
        [Test]
        public void test()
        {
            var driver = new ChromeDriver();
            var adressUrl = "http://przyklady.javastart.pl/jpetstore/";
            driver.Navigate().GoToUrl(adressUrl);
            driver.Manage().Window.Maximize();
            driver.FindElementByCssSelector("#Content a").Click();
            var toolBar = driver.FindElementById("MenuContent");
            //wchodzimy ns strone klimamy i sprawdzamy czy przekiruje nas na dobrą stronę
            Assert.NotNull(toolBar);
            driver.Close();
        }
        
    }
}
