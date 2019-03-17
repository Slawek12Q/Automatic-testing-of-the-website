using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Testy_Selemium_Automatyzacja.BazaTestow
{
    // klasa służaca do przechowywania dirvera jest to singleton bo potrzebna mam jest tylko jedna instancja tego drivera
    // zwieksza to szybkość programu oraz jego zwieksza prostote
    [TestFixture]
    class DriveManager
    {
        private static IWebDriver driver { get; set; }

        private DriveManager() { }

        public static IWebDriver getDriver ()
        {
            if(driver == null)
            {
                driver = new ChromeDriver();
            }

            return driver;
        }

        public static void wylaczDrivera ()
        {
            driver.Close();
            driver.Quit();
            driver = null;
        }
    }
}
