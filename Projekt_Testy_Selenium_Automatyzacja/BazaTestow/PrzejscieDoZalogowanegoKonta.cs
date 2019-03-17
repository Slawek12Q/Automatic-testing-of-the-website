using NUnit.Framework;
using Projekt_Testy_Selemium_Automatyzacja.PageObjectPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//mamy duzo testow na zalogowanym uzytkowniku wiec aby nie pisac tego w kazdym tescie gdzie potrzebujemy byc zalogowani to wydzielilismy to 
// sobie do klasy nadrzednej z ktorej inne klasy beda dziedziczyc
namespace Projekt_Testy_Selemium_Automatyzacja.BazaTestow
{
    [TestFixture]
    class PrzejscieDoZalogowanegoKonta : BazaTestowa
    {

        [SetUp]
        public void przedDoKonta ()
        {
            StronaPoczatkowa poczatkowa = new StronaPoczatkowa();
            poczatkowa.kliknijIWejdzNaStrone()
                .kliknijWLinkDoLogowania()
                .wprowadzLogin("j2ee")
                .wprowadzHaslo("j2ee")
                .kliknijWPrzyciskLogowania();
        }

    }
}
