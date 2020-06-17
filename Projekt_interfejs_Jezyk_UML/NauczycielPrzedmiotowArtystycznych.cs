using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Projekt_interfejs_Jezyk_UML
{
    class NauczycielPrzedmiotowArtystycznych : Nauczyciel
    {
        private string utwor;
        public string Utwor
        {
            get { return utwor; }
            set { utwor = value; }
        }

        private string dzielo;
        public string Dzielo
        {
            get { return dzielo; }
            set { dzielo = value; }
        }

        private string obraz;
        public string Obraz
        {
            get { return obraz; }
            set { obraz = value; }
        }

        public void zagrajUtwor(string utwor)
        {
            Utwor = utwor;
            String message = "Gram utwór " + Utwor + ".";
        }

        public void zinterpretujDzielo(string dzielo)
        {
            Dzielo = dzielo;
            String message = "Interpretuję dzieło " + Dzielo + ".";
        }

        public void malujObraz(string obraz)
        {
            Obraz = obraz;
            String message = "Maluję obraz " + Obraz + ".";
        }

        public string zrobCwiczenieArtystyczne()
        {
            return "Robię ćwiczenie artystyczne.";
        }

        public string przywitajKlase()
        {
            return "Witaj, klaso :)";
        }

    }
}
