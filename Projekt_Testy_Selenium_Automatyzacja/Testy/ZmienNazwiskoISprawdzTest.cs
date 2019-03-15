using NUnit.Framework;
using Projekt_Testy_Selemium_Automatyzacja.BazaTestow;
using Projekt_Testy_Selemium_Automatyzacja.PageObjectPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Testy_Selemium_Automatyzacja.Testy
{
    [TestFixture]
    class ZZmienNazwiskoISprawdzTest : PrzejscieDoZalogowanegoKonta
    {
        [Test]
        public void test()
        {
            GorneMenuPoZalogowaniu menuPoZalogowaniu = new GorneMenuPoZalogowaniu();
            menuPoZalogowaniu.przejdzDoMojegoKonta()
                .zmienNazwisko("Kowalski")
                .zatwierdzDane();

            MojeKonto mojeKonto = new MojeKonto();

            String wiadomosc = mojeKonto.pobierzNazwisko();

            Assert.AreEqual(wiadomosc, "Kowalski");
        }
    }
}
