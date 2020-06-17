using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    class Dyrektor : PracownikOswiaty
    {
        /// <summary>
        /// Properties Dostępność dyrektora
        /// </summary>
        private bool dostepnosc;
        public bool Dostepnosc
        {
            get
            {
                return dostepnosc;
            }
            set
            {
                dostepnosc = value;
            }
        }

        /// <summary>
        /// Dyrektor wydaje rozporządzenie
        /// </summary>
        /// <returns>rozporzadzenie</returns>
        public string wydajRozporzadzenie()
        {
            string rozporzadzenie = "Rozporządzenie";
            return rozporzadzenie;
        }

        /// <summary>
        /// Dyrektor zamyka szkołę
        /// Szkoła zamknięta -> true
        /// Szkoła otwarta -> false
        /// </summary>
        /// <param name="szkola">Obiekt Szkoła</param>
        /// <returns>Stan szkoły</returns>
        public bool zamknijSzkole(Szkola szkola)
        {
            bool stanSzkoly = false;
            if(szkola.StanSzkoly == false)
            {
                stanSzkoly = true;
            }
            return stanSzkoly;
        }

        /// <summary>
        /// Dyrektor otwiera szkołę
        /// Szkoła zamknięta -> true
        /// Szkoła otwarta -> false
        /// </summary>
        /// <param name="szkola">Obiekt Szkoła</param>
        /// <returns>Stan szkoły</returns>
        public bool otworzSzkole(Szkola szkola)
        {
            bool stanSzkoly = false;
            if(szkola.StanSzkoly == true)
            {
                stanSzkoly = false;
            }

            return stanSzkoly;
        }

        /// <summary>
        /// Dyrektor rekrutuje ucznia
        /// </summary>
        /// <param name="uczen">Obiekt uczeń</param>
        /// <returns>Obiekt uczeń</returns>
        public Uczen zrekrutujUcznia(Uczen uczen)
        {
            string stanRekrutacji = "Rekrutuję ucznia...";
            return uczen;
        }

        /// <summary>
        /// Oblicza wypłatę dyrketora
        /// </summary>
        /// <returns>wypłata:int</returns>
        public override int obliczWyplate()
        {
            return 8000;
        }
    }
}
