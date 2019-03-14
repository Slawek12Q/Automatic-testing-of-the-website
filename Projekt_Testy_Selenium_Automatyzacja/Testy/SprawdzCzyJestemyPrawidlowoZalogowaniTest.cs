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
    class SprawdzCzyJestemyPrawidlowoZalogowaniTest : PrzejscieDoZalogowanegoKonta
    {
        [Test]
        public void test()
        {
            GorneMenuPoZalogowaniu menuPoZalogowaniu = new GorneMenuPoZalogowaniu();
            String uzytkownik = menuPoZalogowaniu.przejdzDoMojegoKonta()
                .pobierzUzytkownika();

            Assert.AreEqual(uzytkownik, "j2ee");
        }
        

        
    }
}
