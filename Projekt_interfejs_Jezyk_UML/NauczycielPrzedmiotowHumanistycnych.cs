using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    class NauczycielPrzedmiotowHumanistycnych : Nauczyciel
    {
        private string wiersz;
        public string Wiersz
        {
            get { return wiersz; }
            set { wiersz = value; }
        }

        private string lektura;
        public string Lektura
        {
            get { return lektura; }
            set { lektura = value; }
        }

        private string dyktando;
        public string Dyktando
        {
            get { return dyktando; }
            set { dyktando = value; }
        }

        public string rycytujWiersz(string wiersz)
        {
            wiersz = Wiersz;
            return "Rycytuję wiersz " + wiersz + ".";
        }

        public string interpretujLekture(string lektura)
        {
            lektura = Lektura;
            return "Interpretuję lekturę " + lektura + ".";
        }

        public string SprawdzWypracowanie()
        {
            return "Sprawdzam wypracowanie.";
        }

        public string ZrobDyktando(Klasa klasa)
        {
            return "Robię dyktando klasie: " + klasa.NumerKlasy + " Ilość uczniów piszących dyktando: " + klasa.IloscUczniow + ".";
        }

        public override int obliczWyplate()
        {
            return base.obliczWyplate();
        }

        public string przywitajKlase()
        {
            return "Witaj, klaso :)";
        }
    }
}
