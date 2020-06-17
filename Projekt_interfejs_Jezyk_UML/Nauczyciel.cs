using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    class Nauczyciel : PracownikOswiaty
    {
        private bool wychowawca;
        public bool Wychowawca
        {
            get { return wychowawca; }
            set { wychowawca = value; }
        }

        private string przedmiot;
        public string Przedmiot
        {
            get { return przedmiot; }
            set { przedmiot = value; }
        }

        private Klasa[] klasy;
        private static int indexKlasy = 0;
        private Klasa klasa;
        public Klasa[] Klasy
        {
            get { return klasy; }
            set 
            {
                if(indexKlasy < 0)
                {
                    klasy[indexKlasy] = klasa;
                    indexKlasy++;
                }
            }
        }

        public override int obliczWyplate()
        {
            return 2400;
        }
    }
}
