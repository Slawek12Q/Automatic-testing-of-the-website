using NUnit.Framework;
using Projekt_Testy_Selemium_Automatyzacja.PageObjectPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Testy_Selemium_Automatyzacja.Testy
{
    [TestFixture]
    class BlednaProbaLogowaniaTest : BazaTestowa
    {
        [Test]
        public void test()
        {
            StronaPoczatkowa poczatkowa = new StronaPoczatkowa();

            poczatkowa.kliknijIWejdzNaStrone()
                .kliknijWLinkDoLogowania()
                .wprowadzLogin("ala")
                .wprowadzHaslo("ela")
                .kliknijWPrzyciskLogowania();

            StronaLogowania stronaLogowania = new StronaLogowania();

            String wiadomosc = stronaLogowania.pobierzWiadomosc();

            Console.WriteLine(wiadomosc);

            Assert.AreEqual("Invalid username or password. Signon failed.", wiadomosc);
        }

    }
}
