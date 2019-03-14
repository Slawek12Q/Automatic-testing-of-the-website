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
    class PoprawnaProbaLogowaniaTest : BazaTestowa
    {
        [Test]
        public void test()
        {
            StronaPoczatkowa poczatkowa = new StronaPoczatkowa();
            Boolean czyBannerJestWidoczny = poczatkowa.kliknijIWejdzNaStrone()
                .kliknijWLinkDoLogowania()
                .wprowadzLogin("j2ee")
                .wprowadzHaslo("j2ee")
                .kliknijWPrzyciskLogowania()
                .czyBanerJestWyswietlony();

            Assert.IsTrue(czyBannerJestWidoczny);
        }
    }
}
