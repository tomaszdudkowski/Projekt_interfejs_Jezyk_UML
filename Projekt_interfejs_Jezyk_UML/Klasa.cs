using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    public class Klasa
    {
        private int iloscUczniow;
        public int IloscUczniow
        {
            get { return iloscUczniow; }
            set { iloscUczniow = value; }
        }

        private int numerKlasy;
        public int  NumerKlasy
        {
            get { return numerKlasy; }
            set { numerKlasy = value; }
        }

        private string wychowawca;
        public string Wychowawca
        {
            get { return wychowawca; }
            set { wychowawca = value; }
        }

        private List<Uczen> listaUczniow = new List<Uczen>();
        public List<Uczen> ListaUczniow
        {
            get { return listaUczniow; }
        }

        /// <summary>
        /// Dodawanie ucznia do listy uczniów klasy.
        /// Zwiększa ilość uczniów w klasie o jeden.
        /// </summary>
        /// <param name="uczen">Uczeń</param>
        public void dodajUcznia(Uczen uczen)
        {
            listaUczniow.Add(uczen);
            IloscUczniow += 1;
        }

        /// <summary>
        /// Usuwanie ucznia z listy uczniów klasy.
        /// Zmniejsza ilość uczniów o jeden.
        /// </summary>
        /// <param name="numerID">Numer ID ucznia</param>
        public void usunUcznia(int numerID)
        {
            foreach (var uczen in listaUczniow)
            {
                if (uczen.NumerKlasy == numerKlasy)
                {
                    listaUczniow.Remove(uczen);
                }
            }
            IloscUczniow -= 1;
        }

    }
}
