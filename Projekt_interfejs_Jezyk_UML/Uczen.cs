using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    class Uczen
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

        private Klasa klasa;
        public Klasa Klasa
        {
            get { return klasa; }
            set { klasa = value; }
        }

        private int numerID;
        public int NumerID
                {
            get { return numerID; }
            set { numerID = value; }
        }

    }
}
