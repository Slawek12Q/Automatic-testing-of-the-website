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
    class OdznaczenieMojejListTest : PrzejscieDoZalogowanegoKonta
    {
        [Test]
        public void test()
        {
            GorneMenuPoZalogowaniu menuPoZalogowaniu = new GorneMenuPoZalogowaniu();
            Boolean czyZaznaczone = menuPoZalogowaniu
                .przejdzDoMojegoKonta()
                .kiknijWMyList()
                .czyMojaLista();

            Assert.IsFalse(czyZaznaczone);
        }
    }
}
