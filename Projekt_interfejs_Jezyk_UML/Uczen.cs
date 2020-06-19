using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    public class Uczen
    {
        private string imie;
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        private string nazwisko;
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        private int numerKlasy;
        public int NumerKlasy
        {
            get { return numerKlasy; }
            set { numerKlasy = value; }
        }

        static private int numerID = 1000;
        public int NumerID
                {
            get { return numerID; }
            set { numerID++; }
        }

    }
}
