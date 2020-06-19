using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    public class Szkola
    {
        private List<Klasa> listaKlas = new List<Klasa>();

        public List<Klasa> ListaKlas
        {
            get
            {
                return listaKlas;
            }
        }

        /// <summary>
        /// Properties Stan Szkoły
        /// Szkoła zamknięta -> true
        /// Szkoła otwarta -> false
        /// </summary>
        private bool stanSzkoly;
        public bool StanSzkoly {
            get
            {
                return stanSzkoly;
            }
            set 
            { 
                stanSzkoly = value; 
            } 
        }

        /// <summary>
        /// Properties Ilość Klas
        /// </summary>
        static private int iloscKlas;
        public int IloscKlas { 
            get
            {
                return iloscKlas;
            }
            set
            {
                iloscKlas = value;
            } 
        }

        /// <summary>
        /// Dodawanie klasy do listy klas.
        /// Zwiększa ilość klas o jeden.
        /// </summary>
        /// <param name="klasa">Klasa</param>
        public void dodajKlase(Klasa klasa)
        {
            listaKlas.Add(klasa);
            IloscKlas += 1;
        }
        
        /// <summary>
        /// Usuwanie klasy z listy klas.
        /// Zmniejsza ilość klas o jeden.
        /// </summary>
        /// <param name="numerKlasy">Numer klasy</param>
        public void usunKlase(int numerKlasy)
        {
            foreach (var klasa in listaKlas)
            {
                if(klasa.NumerKlasy == numerKlasy)
                {
                    listaKlas.Remove(klasa);
                    break;
                }
            }
            IloscKlas -= 1;
        }
    }
}
